let x = 10
let y = 20

let add x y = x + y

let z = add x y

printf "%d" z

// Creating new variables for updated values to avoid mutation of original ones
let x2 = 100
let y2 = 200

printf "%d" (add x2 y2)