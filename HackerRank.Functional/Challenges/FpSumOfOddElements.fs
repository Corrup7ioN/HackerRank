module FpSumOfOddElements

open System

let readLines =
     Seq.initInfinite (fun _ -> Console.ReadLine())
     |> Seq.takeWhile(fun line -> line <> null);;

let odd num = 
    num % 2 <> 0

let main() = 
    readLines
        |> Seq.map int
        |> Seq.filter odd
        |> Seq.sum
        |> printfn "%d"
    0
