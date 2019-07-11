namespace App

open System.Collections.Generic

module Main =
    let createGraph (maze: string [] []): Dictionary<(int * int), (int * int) list> =
      let graph = new Dictionary<(int * int), (int * int) list> ()
      let mutable count1 = 0
      for item1 in maze do
        let mutable count2 = 0
        for _item2 in item1 do
          let mutable arr: (int * int) list = []
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

    let procedure (maze: string [] []) (start: int * int) (goal: int * int): int =
      let queue = [start]
      let graph = new Dictionary<(int * int), (int * int)> ()

      // let rec search (maze: string [] []) (queue: (int * int) list) (checked: (int * int) list) (graph: Record) (goal: int * int): int =

      1

    [<EntryPoint>]
    let main _argv: int =
        // let inputNums1 = stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList
        // let R = inputNums1.Head
        // let inputNums2 = stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList
        // let inputNums3 = stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList

        // let rec readMaze (count: int) (maze: string [] []) =
        //   match count with
        //   | 0 -> maze
        //   | _ -> Array.append maze [|(stdin.ReadLine().ToCharArray() |> Array.map string)|] |> readMaze (count-1)

        // readMaze |> printfn "%A"

        createGraph [|[|"."; "."|]|] |> printfn "%A"

        0