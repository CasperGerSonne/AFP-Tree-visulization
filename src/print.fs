module Print

open CmdLine

let run (opts: CmdLine.PrintOptions) :int =
    printfn "did a print!"
    0