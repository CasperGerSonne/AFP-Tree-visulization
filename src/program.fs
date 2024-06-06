module Main

open CmdLine
open Test
open Print

/// The compiler entry point.  Must return zero on success, non-zero on error.
[<EntryPoint>]
let main (args: string[]) : int =
    match (CmdLine.parse args) with
    | CmdLine.ParseResult.Error(exitCode) -> exitCode // Non-zero exit code
    | CmdLine.ParseResult.Print(opts) -> Print.run opts
    | CmdLine.ParseResult.Test(opts) -> Test.run opts
