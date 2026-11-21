// Test lists
let list1 = [3; 8; 15; 22; 7]
let list2 = [10; 25; 4; 18; 9]
let list3 = [-6; 11; -2; 14; 5]

let runTests (name: string) (numbers: int list) =
    printfn "%s: %A" name numbers

    // (1) List.map: square every element
    let squares = numbers |> List.map (fun x -> x * x)
    printfn "Squares:      %A" squares

    // (2) List.filter: keep only even numbers
    let evens = numbers |> List.filter (fun x -> x % 2 = 0)
    printfn "Even numbers: %A" evens

    // (3) List.fold: sum and product
    let sum = numbers |> List.fold (fun acc x -> acc + x) 0
    let product = numbers |> List.fold (fun acc x -> acc * x) 1
    printfn "Sum:          %d" sum
    printfn "Product:      %d" product

    // (3) List.reduce: maximum
    let maximum = numbers |> List.reduce (fun a b -> if a > b then a else b)
    printfn "Maximum:      %d" maximum
    printfn ""

// (4) Test on multiple lists
runTests "LIST 1" list1
runTests "LIST 2" list2
runTests "LIST 3" list3