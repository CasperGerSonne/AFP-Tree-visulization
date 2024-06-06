#r "nuget: FsCheck";
open FsCheck 

let rec sumA xs acc = 
    match xs with
    |[] -> acc
    |x::xs' -> (sumA xs' acc) + acc

let sumRefProp xs = List.sum xs = sumA xs 0

let _ = Check.Quick sumRefProp;;