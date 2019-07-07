open System

module Procedure =
    let procedure n d xList =
        let mutable res = 0
        for i1 in 0 .. n-1 do
            for i2 in 0 .. d-1 dofi
                let a = xList.[i1].[i2]
        res

[<EntryPoint>]
let main _argv =
    let inputFirstLineNumbers = stdin.ReadLine().Split(' ') |> Array.map int
    let n = inputFirstLineNumbers.[0]
    let d = inputFirstLineNumbers.[1]
    let mutable xList : int list list = []
    for _i in 1 .. n do
        let a = [stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList]
        xList <- xList @ a
        
    Procedure.procedure n d xList |> printfn "%d"
    0
 