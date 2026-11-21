open System

let rec hasDivisor (n: int) (d: int) : bool =
    if d * d > n then false
    elif n % d = 0 then true
    else hasDivisor n (d + 1)

let isPrime (n: int) : bool =
    n >= 2 && not (hasDivisor n 2)

let rec run () =
    printf "Enter an integer (or q to quit): "
    let input = Console.ReadLine()
    match input with
    | "q" | "Q" -> printfn "Done."
    | _ ->
        match Int32.TryParse input with
        | true, n ->
            printfn "%d -> %s" n (if isPrime n then "Prime" else "Not prime")
        | _ ->
            printfn "Invalid input, please enter a whole number."
        run ()

run ()