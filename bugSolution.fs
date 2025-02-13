let addOne x = x + 1

let mutable x = 10

let y = addOne x

printfn "%d" y //Prints 11

x <- 20

let z = addOne x //Call the function again with the updated x value

printfn "%d" z //Prints 21