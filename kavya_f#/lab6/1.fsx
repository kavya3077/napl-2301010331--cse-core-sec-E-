open System

let readMark (n: int) : float =
    printf "Enter marks for subject %d: " n
    Console.ReadLine() |> float

let classify (percentage: float) : string =
    match percentage with
    | p when p >= 60.0 -> "First Division"
    | p when p >= 50.0 -> "Second Division"
    | p when p >= 40.0 -> "Third Division"
    | _ -> "Fail"

let marks = [1 .. 4] |> List.map readMark
let percentage = (List.sum marks) / 4.0

printfn ""
printfn "Percentage: %.2f%%" percentage
printfn "Division  : %s" (classify percentage)