module FpArrayOfNElements

open System

let f n = 
    n
        |> fun n -> Seq.init n (fun i -> i + 1)
        |> Seq.map string
        |> String.concat ", "
        |> printfn "[%s]"

let main() = 
    Console.ReadLine()
        |> int
        |> f
    0