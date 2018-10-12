  
(*  
    1. Tabeller: Betragt funktionerne i fig 5. Læg mærke til at n er antallet af elementer
*)
(*  
    1.1 Hvad returnerer T1([2,3,1,4,3],5) og T1([0,-1,1],3)? Beskriv mere generelt hvad T1 gør.
*)
let T1((A: int list), n') = 
    
    let mutable x = 0
    let mutable n = n'

    for i = 0 to n - 1 do

        // printfn "i in the for loop is %i, and n is %i, x is %i, A[i] is %i" i n x
        x <- x + A.[i]
        printfn "x changed value to %i, i is %i, A.[i] is %i" x i A.[i]
    

    printfn "x returns %i" x

// let A = [ 2; 3; 1; 4; 3 ]
// T1(A, 5)

// let A = [ 0; -1 ; 1 ]
// T1(A, 3)

// T1 adderer elementerne i listen A.


(*  
    1.2 Hvad returnerer T2([2,3,4,2],4,2) og T2([2,3,4,2],4,3)? Beskriv mere generelt hvad T2 gør.
*)
let T2((A: int list), n, y) = 
    
    let mutable x = 0

    for i = 0 to n - 1 do

        printfn "i is %i, A.[i] is %i, y is %i" i A.[i] y
        if A.[i] = y then 

            printfn "A.[i] is equal to y!, A.[i]=%i, y=%i" A.[i] y

            x <- x + 1

            printfn "x changed value to %i" x

    printfn "x returns %i" x

// let A = [ 2; 3; 4; 2 ]
// T2(A, 4, 2)

// let A = [ 2; 3; 4; 2 ]
// T2(A, 4, 3)

// T2 returnerer x for antallet af gange y-værdien var det samme som indholdet af A[i]-værdien.


(*
1.3 Hvad returnerer T3([7,10,12,2],4)? Beskriv mere generelt hvad T3 gør.
*)

// in-place swap
let swap i j (arr: int []) =
    let tmp = arr.[i]
    arr.[i] <- arr.[j]
    arr.[j] <- tmp


let A = [ 2; 3; 4; 2 ]
swap(A)




