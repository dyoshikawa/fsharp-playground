open System
open Suave

[<EntryPoint>]
let main _argv =
    startWebServer defaultConfig (Successful.OK "Hello World!")
    0