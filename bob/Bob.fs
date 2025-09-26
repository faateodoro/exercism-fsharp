module Bob

open System

let isQuestion (phrase: string) : bool = 
    phrase.Trim()
    |> Seq.tryLast = Some '?' 

let nothingToSay (phrase: string): bool =
    phrase.Trim() = "" 

let lettersOnly (phrase: string): string  = 
    phrase 
    |> Seq.filter Char.IsLetter
    |> String.Concat

let hasLetters (phrase: string) =
    let cleanPhrase = lettersOnly phrase
    if String.length cleanPhrase = 0 then
        None
    else 
        Some cleanPhrase

let isCapitalized (phrase: string): bool =
    phrase 
    |> lettersOnly
    |> Seq.forall Char.IsUpper

let yellQuestion phrase =
    isCapitalized phrase && isQuestion phrase

let simpleQuestion input =
    isQuestion input && 
    not <| isCapitalized input || 
    hasLetters input = None && 
    isQuestion input

let justYell input = 
    isCapitalized input && hasLetters input |> Option.isSome

let response input =
    match input with
    | input when simpleQuestion input -> "Sure."
    | input when yellQuestion input -> "Calm down, I know what I'm doing!"
    | input when justYell input -> "Whoa, chill out!"
    | input when nothingToSay input -> "Fine. Be that way!"
    | _ -> "Whatever."
