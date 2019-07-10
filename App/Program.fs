namespace App

open System
open Suave

module Main = 
    [<EntryPoint>]
    let main _argv =
        startWebServer defaultConfig (Successful.OK "Hello World!")
        0