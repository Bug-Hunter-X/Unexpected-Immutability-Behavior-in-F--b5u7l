let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y //Prints 11

x <- 20

printfn "%d" y //Still prints 11, not 22