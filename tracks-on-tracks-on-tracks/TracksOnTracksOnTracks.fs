module TracksOnTracksOnTracks

let newList: string list = []

let existingList: string list = 
    [ "F#"; "Clojure"; "Haskell" ]

let addLanguage (language: string) (languages: string list): string list =
    language :: languages 

let countLanguages (languages: string list): int = 
    languages |> List.length

let reverseList(languages: string list): string list = 
    languages |> List.rev

let excitingList (languages: string list): bool = 
    match languages with
    | [] -> false
    | x when x.Head = "F#" -> true
    | x when (x.Length = 2 || x.Length = 3) && x[1] = "F#" -> true
    | _ -> false