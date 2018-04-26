module ListLength

open System

let readLines =
     Seq.initInfinite (fun _ -> Console.ReadLine())
     |> Seq.takeWhile(fun line -> line <> null);;

let main = 
    readLines
        |> Seq.fold (fun accumulator element -> accumulator + 1) 0
        |> printfn "%d"
    0
