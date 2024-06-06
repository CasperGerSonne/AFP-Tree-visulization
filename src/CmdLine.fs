module CmdLine

open CommandLine

/// Command line options for priniting.
[<Verb("print", HelpText = "print.")>]
type PrintOptions =
    { [<Option('v',
               "verbose",
               HelpText = "Enable verbose output (including the test names, usable with the '--filter' option).")>]
      Verbose: bool }


/// Command line options for testing.
[<Verb("test", HelpText = "Run the test suite.")>]
type TestOptions =
    { [<Option('v',
               "verbose",
               HelpText = "Enable verbose output (including the test names, usable with the '--filter' option).")>]
      Verbose: bool }

      /// Possible result of command line parsing.
      

[<RequireQualifiedAccess>]
type ParseResult =
    | Error of int
    | Print of PrintOptions
    | Test of TestOptions


let parse (args: string[]) : ParseResult =
    let res =
        CommandLine.Parser.Default.ParseArguments<TestOptions, PrintOptions>(
            args
        )

    match res with
    | :? NotParsed<obj> -> ParseResult.Error(1) // Non-zero exit code
    | :? Parsed<obj> as parsed ->
        match parsed.Value with
        | :? PrintOptions as opt -> ParseResult.Print(opt)
        | :? TestOptions as opt -> ParseResult.Test(opt)
        | x -> failwith $"BUG: unexpected command line parsed value: %O{x}"
    | x -> failwith $"BUG: unexpected command line parsing result: %O{x}"
