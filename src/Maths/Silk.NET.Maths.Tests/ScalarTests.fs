module Silk.NET.Maths.Tests.ScalarTests

open System
open Expecto
open FsCheck
open Silk.NET.Maths

let inline num (n:int) : ^t = Seq.init n (fun _ -> LanguagePrimitives.GenericOne) |> Seq.reduce(fun x y -> x + y)

let inline zero<'T> = Unchecked.defaultof<'T>

let inline scalarTests<'T
    when ^T : struct
    and ^T :> ValueType
    and ^T :> IFormattable
    and ^T : equality
    and ^T : comparison
    and ^T : (new : unit -> ^T)
    and ^T : (static member (+) : ^T * ^T -> ^T)
    and ^T : (static member Zero : ^T)
    and ^T : (static member One : ^T)> =
    
    testList (sprintf "Scalar<%s> Tests" typedefof<'T>.Name) [
        testList "Add" [
            testProperty "Commutative" <|
                fun (a:^T, b:^T) ->
                    ((Scalar.IsNormal a) && (Scalar.IsNormal b))
                        ==> (Scalar.Add<'T> (a, b) = Scalar.Add<'T> (b, a))
            testProperty "0 is nothing" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a)
                        ==> (Scalar.Add<'T> (a, zero<'T>) = a)
            testCase "1 + 2 = 3" <|
            fun () ->
                let one = num<'T> 1
                let two = num<'T> 2
                let actual = Scalar.Add<'T> (one, two)
                let three = num<'T> 3
                Expect.equal actual three "1 + 2 = 3"
            testCase "88 + 2 = 90" <|
            fun () ->
                let one = num<'T> 88
                let two = num<'T> 2
                let actual = Scalar.Add<'T> (one, two)
                let expected = num<'T> 90
                Expect.equal actual expected "88 + 2 = 90"
        ]
        
        testList "Subtract" [
            testProperty "0 is nothing" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a)
                        ==> (Scalar.Subtract<'T> (a, zero<'T>) = a)
            testCase "2 - 1 = 1" <|
            fun () ->
                let one = num<'T> 2
                let two = num<'T> 1
                let actual = Scalar.Subtract<'T> (one, two)
                let three = num<'T> 1
                Expect.equal actual three "2 - 1 = 1"
            testCase "88 - 2 = 86" <|
            fun () ->
                let one = num<'T> 88
                let two = num<'T> 2
                let actual = Scalar.Subtract<'T> (one, two)
                let expected = num<'T> 86
                Expect.equal actual expected "88 - 2 = 86"
        ]
        
        testList "Multiply" [
            testProperty "0 is 0" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a)
                        ==> (Scalar.Multiply<'T> (a, zero<'T>) = zero<'T>)
            testProperty "1 is nothing" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a)
                        ==> (Scalar.Multiply<'T> (a, Scalar.One<'T>()) = a)
            testCase "2 * 2 = 4" <|
            fun () ->
                let two = num<'T> 2
                let actual = Scalar.Multiply<'T> (two, two)
                let four = num<'T> 4
                Expect.equal actual four "2 * 2 = 4"
            testCase "88 * 2 = 176" <|
            fun () ->
                let one = num<'T> 88
                let two = num<'T> 2
                let actual = Scalar.Multiply<'T> (one, two)
                let expected = num<'T> 176
                Expect.equal actual expected "88 * 2 = 176"
        ]
        
        testList "Divide" [
            testProperty "1 is nothing" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a)
                        ==> (Scalar.Divide<'T> (a, Scalar.One<'T>()) = a)
            testProperty "a / a = 1" <|
                fun (a:^T) ->
                    (Scalar.IsNormal a && a <> zero<'T>)
                        ==> lazy (Scalar.Divide (a, a) = Scalar.One<'T>())
            testCase "8 / 2 = 4" <|
            fun () ->
                let two = num<'T> 2
                let eight = num<'T> 8
                let actual = Scalar.Divide<'T> (eight, two)
                let four = num<'T> 4
                Expect.equal actual four "8 / 2 = 4"
        ]
        
        testList "Constants" [
            testCase "One is one" <|
                fun () ->
                    Expect.equal (Scalar.One<'T>()) (LanguagePrimitives.GenericOne) "One is one"
            testCase "Two is two" <|
                fun () ->
                    Expect.equal (Scalar.Two<'T>()) (num<'T> 2) "Two is two" 
        ]
        
        testList "Exceptions" [
            testCase "Vector too small throws NotSupportedException" <|
                fun () ->
                    Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "Vector too small throws NotSupportedException"
            testCase "ThrowIndexOutOfRange throws IndexOutOfRangeException" <|
                fun () ->
                    Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRange"
            testCase "ThrowNotSupportedByUnderlying throws ExceptionNotSupported" <|
                fun () ->
                    Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying()) "ThrowNotSupportedByUnderlying throws ExceptionNotSupported"
        ]
        
        testList "Sqrt" [
            testCase "Sqrt(9) = 3" <|
                fun () ->
                    Expect.equal (Scalar.SquareRoot(num<'T> 9)) (num<'T> 3) "Sqrt(9) = 3"
            testProperty "Sqrt(x) < x where x > 1" <|
                fun (x:^T) ->
                    ((Scalar.IsNormal x) && (x > Scalar.One<'T>()))
                    ==> (Scalar.SquareRoot(x) < x)
        ]
    ]
    
[<Tests>]
let uint8ScalarTests = scalarTests<uint8>


[<Tests>]
let int8ScalarTests = scalarTests<int8>


[<Tests>]
let uint16ScalarTests = scalarTests<uint16>


[<Tests>]
let int16ScalarTests = scalarTests<int16>
 
[<Tests>]
let uint32ScalarTests = scalarTests<uint32>


[<Tests>]
let int32ScalarTests = scalarTests<int32>

[<Tests>]
let uint64ScalarTests = scalarTests<uint64>


[<Tests>]
let int64ScalarTests = scalarTests<int64>


[<Tests>]
let float32ScalarTests = scalarTests<float32>


[<Tests>]
let floatScalarTests = scalarTests<float>