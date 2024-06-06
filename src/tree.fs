module Tree
open Types

let rec movetree (postree:PosTree<'a>) distance = 
    match postree with
    | Node((label,x),subtrees) ->  
                        Node((label,(x + distance)),subtrees) 


let moveExtent (e:Extent) (x:real) = List.map(fun (l,r) -> (l+x,r+x))

let rec merge le re = 
    match le, re with
    |[],re-> re
    |le,[] -> le
    |((l,_)::le' , (_,r)::re') -> (l,r)::merge le' re'


let mergelist es = List.fold merge es []

let rec fit le re = 
    match le, re with
    |((_,r)::le' , (l,_)::re') -> max (r-l + 1.0) (fit le' re')
    |_ ,_ -> 0.0

    
let rec fitlistl eList = 
    match eList with
    |


and firlistl'