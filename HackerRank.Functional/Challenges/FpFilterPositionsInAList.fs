module FpFilterPositionsInAList

open System

let readLines =
     Seq.initInfinite (fun _ -> Console.ReadLine())
     |> Seq.takeWhile(fun line -> line <> null);;

//[<EntryPoint>]
let main() = 
    readLines
        |> Seq.indexed
        |> Seq.filter (fun (i, x) -> i % 2 <> 0)
        |> Seq.map snd
        |> Seq.iter (printfn "%s")
    0
