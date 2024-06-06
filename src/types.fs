
type Tree<'a> = 
        |Node of 'a * (Tree<'a> list)

type real = float

type Extent = (real*real) list
