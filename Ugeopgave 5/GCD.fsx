// Beregn GCD

open System

let mutable trin = 1
let rec gcd x y =
    if y = 0 then
        printfn "GCD = %A" x
        x
    else
        printfn "Trin: %A" (trin)
        trin <- trin + 1

        gcd y (x % y)

gcd 5 3
