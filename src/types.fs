module types
type Tree<'a> = 
        |Node of 'a * (Tree<'a> list)
type real = float

type PosTree<'a> = Tree<'a*real>
        



type Extent = (real*real) list
