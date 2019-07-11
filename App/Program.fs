namespace App

open System.Collections.Generic

module Main =
    let createGraph (maze : string [] []) : Dictionary<int * int, (int * int) list> =
        let graph = new Dictionary<int * int, (int * int) list>()
        let mutable count1 = 0
        for item1 in maze do
            let mutable count2 = 0
            for _item2 in item1 do
                let mutable arr : (int * int) list = []
                if count1 < maze.Length - 1 && maze.[count1 + 1].[count2] = "." then
                    arr <- (count1 + 1, count2) :: arr
                if count2 < item1.Length - 1 && maze.[count1].[count2 + 1] = "." then
                    arr <- (count1, count2 + 1) :: arr
                if count1 > 0 && maze.[count1 - 1].[count2] = "." then
                    arr <- (count1 - 1, count2) :: arr
                if count2 > 0 && maze.[count1].[count2 - 1] = "." then
                    arr <- (count1, count2 - 1) :: arr
                graph.Add((count1, count2), arr)
                count2 <- count2 + 1
            count1 <- count1 + 1
        graph

    let procedure (maze : string [] []) (start : int * int) (goal : int * int) : int =
        let queue = new Queue<int * int>()
        let graph = createGraph maze
        queue.Enqueue(start)
        let rec search graph goal count (checkedList : (int * int) list) (queue : Queue<int * int>) : int =
            let dequeued = queue.Dequeue()
            let addedCheckedList = dequeued :: checkedList
            match dequeued with
            | _ when dequeued = goal -> count
            | _ when List.contains dequeued checkedList ->
                search graph goal (count + 1) addedCheckedList queue
            | _ ->
                (fun (graph : Dictionary<int * int, (int * int) list>) (queue : Queue<int * int>) (dequeued : int * int) ->
                for item in graph.[dequeued] do
                    queue.Enqueue(item)
                queue) graph queue dequeued
                |> search graph goal (count + 1) addedCheckedList
        
        search graph goal 0 [] queue

    [<EntryPoint>]
    let main _argv : int =
        let inputNums1 =
            stdin.ReadLine().Split(' ')
            |> Array.map int
            |> Array.toList

        let R = inputNums1.Head

        let inputNums2 =
            stdin.ReadLine().Split(' ')
            |> Array.map int        
        let start = (inputNums2.[0], inputNums2.[1])

        let inputNums3 =
            stdin.ReadLine().Split(' ')
            |> Array.map int
        let goal = (inputNums3.[0], inputNums3.[1])

        let rec readMaze (count : int) (maze : string [] []) =
            match count with
            | 0 -> maze
            | _ ->
                Array.append maze
                    [| (stdin.ReadLine().ToCharArray() |> Array.map string) |]
                |> readMaze (count - 1)

        let maze = readMaze R [|[||]|]

        procedure maze start goal |> printfn "%d"
        0
