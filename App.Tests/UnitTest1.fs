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
        let result = createGraph [|[|"."; "."|]|]
        Assert.AreEqual([(0,1)], result.[(0,0)])
        Assert.AreEqual([(0,0)], result.[(0,1)])
        