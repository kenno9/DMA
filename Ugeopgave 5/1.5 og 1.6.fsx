// 1.5:
// Vi kan se, at fibonaccis talfølge fortsætter i det 'uendelige'
// Den maksimale køretid er O(n), da det netop afhænger af
// størrelsen af n, hvornår vores funktion stopper med at køre.

let rec GCD(a, b) =
  if b = 0 then
    a
  else
    printfn "b: %A" b
    GCD(b, a % b)

printfn "GCD: %A" (GCD(79, 61))


// printfn "%A" (5%2)



// 1.6:
// Køretiden vil aldrig kunne være O(1) for t(n), da køretiden
// netop afhænger af n.



