let rec T a b n =
  if a + b < n then

    let current = a + b
    let rest = T b current n
    current :: rest
  else
    []

let fibbonaci = 1::2::(T 1 2 400)
printfn "%A" fibbonaci