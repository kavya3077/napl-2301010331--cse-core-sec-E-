open System
open System.Text.RegularExpressions

let reverseString (s: string) : string =
    String(Array.rev (s.ToCharArray()))

let isPalindrome (s: string) : bool =
    let t = s.ToLower()
    t = reverseString t

let (|AllLetters|AllDigits|Mixed|) (s: string) =
    if s <> "" && Seq.forall Char.IsLetter s then AllLetters
    elif s <> "" && Seq.forall Char.IsDigit s then AllDigits
    else Mixed

let transform (s: string) : string =
    match s with
    | AllLetters -> s.ToUpper()
    | AllDigits -> string (int64 s * 2L)
    | Mixed -> s

let (|ValidEmail|_|) (s: string) =
    if Regex.IsMatch(s, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$") then Some s else None

let checkEmail (s: string) : string =
    match s with
    | ValidEmail _ -> "Valid"
    | _ -> "Invalid"

printfn "(1) Reverse and Palindrome"
[ "madam"; "eraser"; "racecar"; "12321" ]
|> List.iter (fun s -> printfn "  %s -> %s, palindrome: %b" s (reverseString s) (isPalindrome s))

printfn ""
printfn "(2) Transform"
[ "hello"; "1234567"; "abc1357"; "World"; "31105" ]
|> List.iter (fun s -> printfn "  %s -> %s" s (transform s))

printfn ""
printfn "(3) Email Validation"
[ "rohit.mudgil@outlook.com"; "priya_99@university.ac.in"; "world@hello"; "@missinguser.com"; "user@domain.org" ]
|> List.iter (fun e -> printfn "  %s -> %s" e (checkEmail e))