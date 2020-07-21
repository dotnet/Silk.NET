module Silk.NET.Maths.Tests.UInt64ScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar UInt64 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<uint64>.One 1UL "Scalar<uint64>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<uint64>.Two 2UL "Scalar<uint64>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint64>.Pi |> ignore) "Scalar<uint64>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint64>.Tau |> ignore) "Scalar<uint64>.Tau throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint64>.PositiveInfinity |> ignore) "Scalar<uint64>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint64>.NegativeInfinity |> ignore) "Scalar<uint64>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<uint64>()) 1UL "Scalar.One<uint64>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<uint64>()) 2UL "Scalar.Two<uint64>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<uint64>()) |> ignore) "Scalar.Pi<uint64>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<uint64>()) |> ignore) "Scalar.Tau<uint64>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<uint64>()) |> ignore) "Scalar.PositiveInfinity<uint64>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<uint64>()) |> ignore) "Scalar.NegativeInfinity<uint64>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<uint64>(a) = uint64 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<uint64>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<uint64>()) "ThrowForNonFloatingPointType<uint64> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<uint64>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<uint64> matches underlying" <|
        fun (a:uint64) -> Scalar.SquareRoot<uint64>(a) = uint64 (MathF.Sqrt(float32 a))
        
    testProperty "Add<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> (b <> 0UL) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<uint64>(x, 0) throws DivideByZero" <|
        fun (a:uint64) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0UL) |> ignore) "Divide<uint64>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> (b <> 0UL) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<uint64>(x, 0) throws DivideByZero" <|
        fun (a:uint64) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0UL) |> ignore) "Mod<uint64>(x, 0) throws DivideByZero" 
    
    testProperty "Min<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Min(a, b) = uint64(MathF.Min(float32(a), float32(b)))

    testProperty "Max<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Max(a, b) = uint64(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<uint64> matches HLSL" <|
        fun (a:uint64, b:uint64, c:uint64) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<uint64> matches underlying" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Negate(a) |> ignore) "UInt64 cannot be negated"
        
    testProperty "Equal<uint64> matches underlying" <|
        fun (a:uint64, b:uint64) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<uint64> matches underlying" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of UInt64"
        
    testProperty "Abs<uint64> matches underlying" <|
        fun (a:uint64) -> Scalar.Abs (a) = uint64(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of UInt64"
        
        
    testProperty "Sinh" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of UInt64"


    testProperty "Asin" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of UInt64"
        
        
    testProperty "Atan" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of UInt64"
        
        
    testProperty "Atan2" <|
        fun (a:uint64, b:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of UInt64"


    testProperty "Cos" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of UInt64"

    testProperty "Cosh" <|
        fun (a:uint64) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of UInt64"
]