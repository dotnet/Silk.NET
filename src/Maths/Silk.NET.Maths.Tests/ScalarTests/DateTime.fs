module Silk.NET.Maths.Tests.ScalarTests.DateTime

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar DateTime Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.One |> ignore) "Scalar<DateTime>.One throws"
        testCase "Two" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.Two |> ignore) "Scalar<DateTime>.Two throws"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.Pi |> ignore) "Scalar<DateTime>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.Tau |> ignore) "Scalar<DateTime>.Tau throws"
        testCase "HalfPi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.HalfPi |> ignore) "Scalar<DateTime>.HalfPi throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.PositiveInfinity |> ignore) "Scalar<DateTime>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<DateTime>.NegativeInfinity |> ignore) "Scalar<DateTime>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.One<DateTime>()) |> ignore) "Scalar.One<DateTime>() throws"
        testCase "Two" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Two<DateTime>()) |> ignore) "Scalar.Two<DateTime>() throws"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<DateTime>()) |> ignore) "Scalar.Pi<DateTime>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<DateTime>()) |> ignore) "Scalar.Tau<DateTime>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<DateTime>()) |> ignore) "Scalar.PositiveInfinity<DateTime>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<DateTime>()) |> ignore) "Scalar.NegativeInfinity<DateTime>() throws"
    ]
    
    testProperty "As" <| fun (a:float32) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.As<DateTime>(a)) |> ignore) "Scalar.As<DateTime>() throws"
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowForUnsupportedBaseType<DateTime>())) "ThrowForUnsupportedBaseType<DateTime> throws NotSupportedException"
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<DateTime>()) "ThrowForNonFloatingPointType<DateTime> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<DateTime>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<DateTime> matches underlying" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.SquareRoot<DateTime>(a)) |> ignore) "Scalar.SquareRoot<DateTime>() throws"
        
    testProperty "Add<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Add<DateTime>(a, b)) |> ignore) "Scalar.Add<DateTime>() throws"
        
    testProperty "Subtract<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Subtract<DateTime>(a, b)) |> ignore) "Scalar.Subtract<DateTime>() throws"
    
    testProperty "Multiply<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Multiply<DateTime>(a, b)) |> ignore) "Scalar.Multiply<DateTime>() throws"
    
    testProperty "Divide<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Divide<DateTime>(a, b)) |> ignore) "Scalar.Divide<DateTime>() throws"
        
    testProperty "Mod<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Mod<DateTime>(a, b)) |> ignore) "Scalar.Mod<DateTime>() throws"
    
    testProperty "Min<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Min<DateTime>(a, b)) |> ignore) "Scalar.Min<DateTime>() throws"

    testProperty "Max<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Max<DateTime>(a, b)) |> ignore) "Scalar.Max<DateTime>() throws"

    testProperty "Larger<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Larger<DateTime>(a, b)) |> ignore) "Scalar.Larger<DateTime>() throws"
        
    testProperty "Smaller<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Smaller<DateTime>(a, b)) |> ignore) "Scalar.Smaller<DateTime>() throws"
        
    testProperty "LargerEquals<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.LargerEquals<DateTime>(a, b)) |> ignore) "Scalar.LargerEquals<DateTime>() throws"
        
    testProperty "SmallerEquals<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.SmallerEquals<DateTime>(a, b)) |> ignore) "Scalar.SmallerEquals<DateTime>() throws"
        
    testProperty "Clamp<DateTime> matches HLSL" <|
        fun (a:DateTime, b:DateTime, c:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Clamp<DateTime>(a, b, c)) |> ignore) "Scalar.Clamp<DateTime>() throws"
        
    testProperty "Negate<DateTime> matches underlying" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Negate<DateTime>(a)) |> ignore) "Scalar.Negate<DateTime>() throws"
        
    testProperty "Equal<DateTime> matches underlying" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Equal<DateTime>(a, b)) |> ignore) "Scalar.Equal<DateTime>() throws"
        
    testProperty "Acos<DateTime> matches underlying" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of DateTime"
        
    testProperty "Abs<DateTime> matches underlying" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Abs(a) |> ignore) "Cannot find Abs of DateTime"
        
    testProperty "Sin" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of DateTime"
        
        
    testProperty "Sinh" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of DateTime"


    testProperty "Asin" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of DateTime"
        
        
    testProperty "Atan" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of DateTime"
        
        
    testProperty "Atan2" <|
        fun (a:DateTime, b:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of DateTime"


    testProperty "Cos" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of DateTime"

    testProperty "Cosh" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of DateTime"
        
    testProperty "IsNormal" <|
        fun (a:DateTime) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.IsNormal(a) |> ignore) "DateTime cannot be Normal"
]