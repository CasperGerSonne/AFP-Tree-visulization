module tree
open types

let rec movetree postree distance = 
    match postree with
    | Node((label,x),subtrees) ->  Node((label,(x + distance)),subtrees) 


let moveExtent (e: Extent) x =
    e |> List.map (fun (p, q) -> (p + x, q + x))

let rec merge (ps: Extent) (qs: Extent) =
    match (ps, ps) with
    | ([], qs) -> qs
    | (ps, []) -> ps
    | ((p,_)::ps, (_,q)::qs) -> (p,q) :: merge ps qs
