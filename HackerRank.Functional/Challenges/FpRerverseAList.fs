module FpRerverseAList

open System

let readLines =
     Seq.initInfinite (fun _ -> Console.ReadLine())
     |> Seq.takeWhile(fun line -> line <> null);;

//[<EntryPoint>]
let main() = 
    readLines
        |> Seq.fold (fun accumulator element -> element :: accumulator) []
        |> Seq.iter (printfn "%s")
    0
