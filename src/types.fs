
type Tree<'a> = 
        |Node of 'a * (Tree<'a> list)

type PosTree<'a> = Tree<'a*real>
        

type real = float

type Extent = (real*real) list
