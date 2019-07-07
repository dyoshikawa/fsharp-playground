open System

module Procedure =
    let procedure n d xList =
        for _i in 1 .. n do
            let a = []

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
 