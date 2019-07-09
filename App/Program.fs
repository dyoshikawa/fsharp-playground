open System

[<EntryPoint>]
let main _argv =
    let inputNums = stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList
    let N = inputNums.[0]
    let A = inputNums.[1]
    let B = inputNums.[2]
    
    [ for i in [1 .. N] do
        let total = i.ToString().ToCharArray(0, i.ToString().Length) |> Array.toList |> List.map string |> List.map int |> List.sum
        yield if total >= A && total <= B then i else 0]
        |> List.sum
        |> printfn "%A"
    0