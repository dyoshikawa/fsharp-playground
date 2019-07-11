namespace App.Tests

open NUnit.Framework
open App.Main

[<TestClass>]
type TestClass () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.Test1 () =
        let a = createGraph [|[|".."|]|]
        printfn "%A" a
        Assert.True((a = a))
