// https://www.hackerrank.com/challenges/lambda-march-compute-the-perimeter-of-a-polygon/problem

namespace Extensions.Collections
        
module TypeExtensions =

    type System.Collections.Generic.IEnumerator<'a> with

        member this.AsSequence = 
            seq { while this.MoveNext() do yield this.Current }

module Seq =

    open TypeExtensions

    let headAndTail (sequence : seq<'a>) =
        let enumerator = sequence.GetEnumerator()
        match enumerator.MoveNext() with
            | true -> Some ( enumerator.Current, enumerator.AsSequence )
            | false -> None

    let pairwiseCircular sequence =
        match headAndTail sequence with
            | Some (head, tail) ->  seq {yield head; yield! tail; yield head}
            | None -> Seq.empty
        |> Seq.pairwise


namespace global

module Models =

    type Point = {
        X : int;
        Y : int;
    }


module Input = 

    open System
    open Models

    let private readLines =
        Seq.initInfinite (fun _ -> Console.ReadLine())
            |> Seq.takeWhile(fun line -> line <> null)

    let private mapLineToPoint (l : string) =
        l.Split  ' ' 
            |> Seq.map int 
            |> (fun i -> { X = Seq.item 0 i;  Y = Seq.item 1 i })

    let readPolygon = 
        readLines
            |> Seq.skip 1
            |> Seq.map mapLineToPoint
                

module LambdaMarchComputeThePerimeterOfAPolygon =

    open Extensions.Collections
    open Models 

    let square x =
        pown x 2

    let calculateDistanceBetweenPoints points =
        let (p1, p2) = points
        square (p1.X - p2.X) + square (p1.Y - p2.Y)
            |> float
            |> sqrt

    let calculatePerimeter polygon =
        polygon 
            |> Seq.pairwiseCircular
            |> Seq.map calculateDistanceBetweenPoints
            |> Seq.sum

    //[<EntryPoint>]
    let main args = 
        Input.readPolygon
            |> calculatePerimeter
            |> printfn "%.1f"
        0
