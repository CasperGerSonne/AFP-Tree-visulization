module Test
open FsCheck 
open Tree
open Types

let rec sumA xs acc = 
    match xs with
    |[] -> acc
    |x::xs' -> (sumA xs' (acc+x))
let sumRefProp xs = List.sum xs = sumA xs 0

let _ = Check.Quick sumRefProp;;


// test movetree 
let movetreeRefProp (postree : PosTree<string>)  (movedist:real) = 
        match movetree postree movedist with 
        |Node((_,newx),_) -> 
                match postree with 
                | Node((_,oldx),_) -> newx = oldx + movedist


let _ = Check.Quick movetreeRefProp;;


let internal test1 =
    1 = 1

let run (opts: CmdLine.TestOptions) :int =
    if test1
    then
        printfn "test parsed" 
        0
    else 1
