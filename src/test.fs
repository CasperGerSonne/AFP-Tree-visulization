module Test

// #r "nuget: FsCheck";
//open FsCheck 

//let rec sumA xs acc = 
//    match xs with
 //   |[] -> acc
   // |x::xs' -> (sumA xs' acc) + acc

//let sumRefProp xs = List.sum xs = sumA xs 0

// let _ = Check.Quick sumRefProp;;

let internal test1 =
    1 = 1

let run (opts: CmdLine.TestOptions) :int =
    if test1
    then
        printfn "test parsed" 
        0
    else 1