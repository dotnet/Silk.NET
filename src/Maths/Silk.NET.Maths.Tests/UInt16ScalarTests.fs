module Silk.NET.Maths.Tests.UInt16ScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar UInt16 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<uint16>.One 1us "Scalar<uint16>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<uint16>.Two 2us "Scalar<uint16>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint16>.Pi |> ignore) "Scalar<uint16>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint16>.Tau |> ignore) "Scalar<uint16>.Tau throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint16>.PositiveInfinity |> ignore) "Scalar<uint16>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint16>.NegativeInfinity |> ignore) "Scalar<uint16>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<uint16>()) 1us "Scalar.One<uint16>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<uint16>()) 2us "Scalar.Two<uint16>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<uint16>()) |> ignore) "Scalar.Pi<uint16>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<uint16>()) |> ignore) "Scalar.Tau<uint16>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<uint16>()) |> ignore) "Scalar.PositiveInfinity<uint16>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<uint16>()) |> ignore) "Scalar.NegativeInfinity<uint16>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<uint16>(a) = uint16 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<uint16>()
        testCase "ThrowForIntegerBaseType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForIntegerBaseType<uint16>()) "ThrowForIntegerBaseType<uint16> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<uint16>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<uint16> matches underlying" <|
        fun (a:uint16) -> Scalar.SquareRoot<uint16>(a) = uint16 (MathF.Sqrt(float32 a))
        
    testProperty "Add<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> (b <> 0us) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<uint16>(x, 0) throws DivideByZero" <|
        fun (a:uint16) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0us) |> ignore) "Divide<uint16>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> (b <> 0us) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<uint16>(x, 0) throws DivideByZero" <|
        fun (a:uint16) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0us) |> ignore) "Mod<uint16>(x, 0) throws DivideByZero" 
    
    testProperty "Min<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Min(a, b) = uint16(MathF.Min(float32(a), float32(b)))

    testProperty "Max<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Max(a, b) = uint16(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<uint16> matches HLSL" <|
        fun (a:uint16, b:uint16, c:uint16) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<uint16> matches underlying" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Negate(a) |> ignore) "UInt16 cannot be negated"
        
    testProperty "Equal<uint16> matches underlying" <|
        fun (a:uint16, b:uint16) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<uint16> matches underlying" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of UInt16"
        
    testProperty "Abs<uint16> matches underlying" <|
        fun (a:uint16) -> Scalar.Abs (a) = uint16(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of UInt16"
        
        
    testProperty "Sinh" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of UInt16"


    testProperty "Asin" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of UInt16"
        
        
    testProperty "Atan" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of UInt16"
        
        
    testProperty "Atan2" <|
        fun (a:uint16, b:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of UInt16"


    testProperty "Cos" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of UInt16"

    testProperty "Cosh" <|
        fun (a:uint16) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of UInt16"
]