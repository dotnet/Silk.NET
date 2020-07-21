module Silk.NET.Maths.Tests.Int64ScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar Int64 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<int64>.One 1L "Scalar<int64>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<int64>.Two 2L "Scalar<int64>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int64>.Pi |> ignore) "Scalar<int64>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int64>.Tau |> ignore) "Scalar<int64>.Tau throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int64>.PositiveInfinity |> ignore) "Scalar<int64>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int64>.NegativeInfinity |> ignore) "Scalar<int64>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<int64>()) 1L "Scalar.One<int64>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<int64>()) 2L "Scalar.Two<int64>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<int64>()) |> ignore) "Scalar.Pi<int64>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<int64>()) |> ignore) "Scalar.Tau<int64>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<int64>()) |> ignore) "Scalar.PositiveInfinity<int64>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<int64>()) |> ignore) "Scalar.NegativeInfinity<int64>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<int64>(a) = int64 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<int64>()
        testCase "ThrowForIntegerBaseType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForIntegerBaseType<int64>()) "ThrowForIntegerBaseType<int64> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<int64>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<int64> matches underlying" <|
        fun (a:int64) -> Scalar.SquareRoot<int64>(a) = int64 (MathF.Sqrt(float32 a))
        
    testProperty "Add<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<int64> matches underlying" <|
        fun (a:int64, b:int64) -> (b <> 0L) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<int64>(x, 0) throws DivideByZero" <|
        fun (a:int64) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0L) |> ignore) "Divide<int64>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<int64> matches underlying" <|
        fun (a:int64, b:int64) -> (b <> 0L) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<int64>(x, 0) throws DivideByZero" <|
        fun (a:int64) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0L) |> ignore) "Mod<int64>(x, 0) throws DivideByZero" 
    
    testProperty "Min<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Min(a, b) = int64(MathF.Min(float32(a), float32(b)))

    testProperty "Max<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Max(a, b) = int64(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<int64> matches HLSL" <|
        fun (a:int64, b:int64, c:int64) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<int64> matches underlying" <|
        fun (a:int64) -> Scalar.Negate(a) = int64 -a
        
    testProperty "Equal<int64> matches underlying" <|
        fun (a:int64, b:int64) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<int64> matches underlying" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of Int64"
        
    testProperty "Abs<int64> matches underlying" <|
        fun (a:int64) -> Scalar.Abs (a) = int64(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of Int64"
        
        
    testProperty "Sinh" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of Int64"


    testProperty "Asin" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of Int64"
        
        
    testProperty "Atan" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of Int64"
        
        
    testProperty "Atan2" <|
        fun (a:int64, b:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of Int64"


    testProperty "Cos" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of Int64"

    testProperty "Cosh" <|
        fun (a:int64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of Int64"
]