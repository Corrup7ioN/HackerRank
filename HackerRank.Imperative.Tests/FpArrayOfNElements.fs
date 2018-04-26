module FpFilterPositionsInAList

open System

let readLines =
     Seq.initInfinite (fun _ -> Console.ReadLine())
     |> Seq.takeWhile(fun line -> line <> null);;

//[<EntryPoint>]
let main argv = 
    readLines
        |> Seq.mapi (fun i x -> (x, i))
        |> Seq.filter (fun (x, i) -> i % 2 <> 0)
        |> Seq.map fst
        |> Seq.iter (printfn "%s")
    0
