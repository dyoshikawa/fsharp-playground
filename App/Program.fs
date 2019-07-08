open System

[<EntryPoint>]
let main _argv =
    let a = stdin.ReadLine() |> int
    let b = stdin.ReadLine() |> int
    let c = stdin.ReadLine() |> int
    let x = stdin.ReadLine() |> int

    [for ia in [0 .. a] do
        for ib in [0 .. b] do
            for ic in [0 .. c] do
                yield ia * 500 + ib * 100 + ic * 50]
        |> List.sumBy (fun y -> if y = x then 1 else 0)
        |> printfn "%d"           
    0
