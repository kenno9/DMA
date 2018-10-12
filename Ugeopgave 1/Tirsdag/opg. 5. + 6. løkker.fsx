  
(*  5. Løkker: Hvad returnerer funktionerne lo0, lo1, lo2, lo3, lo4 og lo5 i figur 3 og 4 når
               n = 4, b = 10, n = 1000
*)

let loop0(n) = 

    let mutable x = 0

    for i = 1 to n do 

        x <- x + 2

    printfn "loop0(): x=%i for n=%i" x n

(*loop0(4), loop0(10), loop0(1000) // loop0 doubles input n*)


let loop1(n) = 

    let mutable x = 0

    for i = 1 to n do 

        for j = 1 to n do

            x <- x + 1

    printfn "loop1(): x=%i for n=%i" x n

(*loop1(4), loop1(10), loop1(1000) // loop1 multiples with itself one time. (n^2)*)

let loop2(n) = 

    let mutable x = 0

    for i = 1 to n do 

        x <- x + 1 

       (* printfn "loop2(): x = %i in the first for i = %i to n = %i" x i n*)

    for j = 1 to n do

        x <- x + 1

        (*printfn "loop2(): x = %i in the second for j = %i to n = %i" x j n*)

    printfn "loop2(): x=%i for n=%i" x n

(*loop2(4), loop2(10), loop2(1000) // loop2 doubles input n*)


let loop3(n) = 

    let mutable x = 0

    for i = 1 to n do 
         (*printfn "loop3(): for loop called, i=%i to n=%i" i n *)

         if i >= n - 1 then 
            (*printfn "loop3(): if condition met, i=%i >= n=%i- 1" i n *)

            for j = 1 to n do
                (*printfn "loop3(): for loop called, j=%i to n=%i" j n *)

                x <- x + 1
                (*printfn "loop3(): x value changed to x=%i" x *)

    printfn "loop3(): x=%i for n=%i" x n

(*loop3(4), loop3(10), loop3(1000) // loop3 doubles input n*)

let loop4(n) = 

    let mutable x = 0 

    for i = 1 to n do 

        for j = 1 to n do

            x <- x + 1

    printfn "loop4(): x=%i for n=%i" x n

(*loop4(4), loop4(10), loop4(1000) // loop4 doubles input n*)

let loop5 n' =

    let mutable x = 0
    let mutable n = n'

    while n > 0 do

        x <- x + 1
        n <- n - 1 

    printfn "loop5(): x=%i for n=%i" x n 

// loop5(4), loop5(10), loop5(1000)

let loop6 n' = // n = 2^k for et heltal k
    
    let mutable x = 0
    let mutable n = n'

    while n > 1 do

        x <- x + 1
        n <- n/2
        printfn "loop6(): n changed to %i" n 

    printfn "loop6(): x=%i for n=%i" x n  

// loop6(4), loop6(16)

let loop7 n' =
    
    let mutable x = 1
    let mutable n = n'

    while n > 0 do

        x <- x * 2
        n <- n - 1
        printfn "loop7(): n changed to %i, x changed to %i" n x 

    printfn "loop7(): x=%i for n=%i" x n  

// loop7(4), loop7(16)






    
