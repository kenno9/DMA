(*
    3. Pseudokode del A: Betragt funktionerne i figur 1
*)

// 3.1. Hvad returnerer funktionerne A1 og A2
let A1() =
    
    let x = 1

    printfn "A1(): x = %i" x

A1()

let A2() = 

    let mutable x = 1

    x <- x + 1

    printfn "A2(): x = %i" x

A2()

// 3.2. Hvad returnerer funktionerne A3, A4, og A5 for n = 4, n = 10 og n = 100
let A3(n) =
    
    let x = n

    printfn "A3(): x = %i" x

A3(4)
A3(10)
A3(100)

let A4(n) = 

    if n > 10 then
        printfn "A4(): n = %i, %i > 10 so return 1" n n
    else
        printfn "A4(): n = %i, %i < 10 so return 0" n n

A4(4)
A4(10)
A4(100)

let A5(n) = 

    let mutable x = 0

    for i = 1 to n do

        x <- x + 2

    printfn "A5(): x = %d" x

A5(4)
A5(10)
A5(100)

(*
    4. Pseudokode del B: Betragt funktionerne i figur 2
*)

// 4.1. Hvad returnerer funktionerne for n = 4, n = 10, n = 100. Og udtryk hvad de returnerer som funktioner af n.
let B1(n) =
    
    let mutable x = n
    x <- x + x
    printfn "B1(): x = %i for n = %i" x n 

B1(4), B1(10), B1(100) // n in doubled as output x

let B2(n) = 
    
    if (n > 10) then

        let mutable x = 1 
        printfn "B2(): x = %i for n = %i" x n

    elif (n = 10) then

        let x = 0
        printfn "B2(): x = %i for n = %i" x n 

    else

        let x = -1
        printfn "B2(): x = %i for n = %i" x n

B2(4), B2(10), B2(100) // differentiates between values >= 10


