module GuessingGame

let reply (guess: int): string = 
    match guess with
    | 41 | 43 -> "So close"
    | x when x > 43 -> "Too high"
    | x when x < 41 -> "Too low"
    | _ -> "Correct"
