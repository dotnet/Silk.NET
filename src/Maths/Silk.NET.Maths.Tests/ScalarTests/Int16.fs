module Silk.NET.Maths.Tests.ScalarTests.Int16

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar Int16 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<int16>.One 1s "Scalar<int16>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<int16>.Two 2s "Scalar<int16>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int16>.Pi |> ignore) "Scalar<int16>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int16>.Tau |> ignore) "Scalar<int16>.Tau throws"
        testCase "HalfPi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int16>.HalfPi |> ignore) "Scalar<int16>.HalfPi throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int16>.PositiveInfinity |> ignore) "Scalar<int16>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int16>.NegativeInfinity |> ignore) "Scalar<int16>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<int16>()) 1s "Scalar.One<int16>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<int16>()) 2s "Scalar.Two<int16>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<int16>()) |> ignore) "Scalar.Pi<int16>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<int16>()) |> ignore) "Scalar.Tau<int16>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<int16>()) |> ignore) "Scalar.PositiveInfinity<int16>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<int16>()) |> ignore) "Scalar.NegativeInfinity<int16>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<int16>(a) = int16 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<int16>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<int16>()) "ThrowForNonFloatingPointType<int16> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<int16>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<int16> matches underlying" <|
        fun (a:int16) -> Scalar.SquareRoot<int16>(a) = int16 (MathF.Sqrt(float32 a))
        
    testProperty "Add<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<int16> matches underlying" <|
        fun (a:int16, b:int16) -> (b <> 0s) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<int16>(x, 0) throws DivideByZero" <|
        fun (a:int16) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0s) |> ignore) "Divide<int16>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<int16> matches underlying" <|
        fun (a:int16, b:int16) -> (b <> 0s) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<int16>(x, 0) throws DivideByZero" <|
        fun (a:int16) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0s) |> ignore) "Mod<int16>(x, 0) throws DivideByZero" 
    
    testProperty "Min<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Min(a, b) = int16(MathF.Min(float32(a), float32(b)))

    testProperty "Max<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Max(a, b) = int16(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<int16> matches HLSL" <|
        fun (a:int16, b:int16, c:int16) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<int16> matches underlying" <|
        fun (a:int16) -> Scalar.Negate(a) = int16 -a
        
    testProperty "Equal<int16> matches underlying" <|
        fun (a:int16, b:int16) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<int16> matches underlying" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of Int16"
        
    testProperty "Abs<int16> matches underlying" <|
        fun (a:int16) -> Scalar.Abs (a) = int16(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of Int16"
        
        
    testProperty "Sinh" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of Int16"


    testProperty "Asin" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of Int16"
        
        
    testProperty "Atan" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of Int16"
        
        
    testProperty "Atan2" <|
        fun (a:int16, b:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of Int16"


    testProperty "Cos" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of Int16"

    testProperty "Cosh" <|
        fun (a:int16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of Int16"
        
    testProperty "IsNormal" <| fun (a:int16) -> Expect.equal (Scalar.IsNormal<int16>(a)) true
]