module tree
open types

let rec movetree postree distance = 
    match postree with
    | Node((label,x),subtrees) ->  Node((label,(x + distance)),subtrees) 
                            