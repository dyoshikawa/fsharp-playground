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
        Assert.Pass()
