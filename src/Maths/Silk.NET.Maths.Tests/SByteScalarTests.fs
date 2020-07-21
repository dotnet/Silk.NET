module Silk.NET.Maths.Tests.SByteScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar SByte Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<sbyte>.One 1y "Scalar<sbyte>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<sbyte>.Two 2y "Scalar<sbyte>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<sbyte>.Pi |> ignore) "Scalar<sbyte>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<sbyte>.Tau |> ignore) "Scalar<sbyte>.Tau throws"
        testCase "HalfPi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<sbyte>.HalfPi |> ignore) "Scalar<sbyte>.HalfPi throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<sbyte>.PositiveInfinity |> ignore) "Scalar<sbyte>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<sbyte>.NegativeInfinity |> ignore) "Scalar<sbyte>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<sbyte>()) 1y "Scalar.One<sbyte>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<sbyte>()) 2y "Scalar.Two<sbyte>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<sbyte>()) |> ignore) "Scalar.Pi<sbyte>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<sbyte>()) |> ignore) "Scalar.Tau<sbyte>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<sbyte>()) |> ignore) "Scalar.PositiveInfinity<sbyte>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<sbyte>()) |> ignore) "Scalar.NegativeInfinity<sbyte>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<sbyte>(a) = sbyte a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<sbyte>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<sbyte>()) "ThrowForNonFloatingPointType<sbyte> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<sbyte>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<sbyte> matches underlying" <|
        fun (a:sbyte) -> Scalar.SquareRoot<sbyte>(a) = sbyte (MathF.Sqrt(float32 a))
        
    testProperty "Add<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> (b <> 0y) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<sbyte>(x, 0) throws DivideByZero" <|
        fun (a:sbyte) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0y) |> ignore) "Divide<sbyte>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> (b <> 0y) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<sbyte>(x, 0) throws DivideByZero" <|
        fun (a:sbyte) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0y) |> ignore) "Mod<sbyte>(x, 0) throws DivideByZero" 
    
    testProperty "Min<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Min(a, b) = sbyte(MathF.Min(float32(a), float32(b)))

    testProperty "Max<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Max(a, b) = sbyte(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<sbyte> matches HLSL" <|
        fun (a:sbyte, b:sbyte, c:sbyte) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<sbyte> matches underlying" <|
        fun (a:sbyte) -> Scalar.Negate(a) = sbyte -a
        
    testProperty "Equal<sbyte> matches underlying" <|
        fun (a:sbyte, b:sbyte) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<sbyte> matches underlying" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of SByte"
        
    testProperty "Abs<sbyte> matches underlying" <|
        fun (a:sbyte) -> Scalar.Abs (a) = sbyte(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of SByte"
        
        
    testProperty "Sinh" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of SByte"


    testProperty "Asin" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of SByte"
        
        
    testProperty "Atan" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of SByte"
        
        
    testProperty "Atan2" <|
        fun (a:sbyte, b:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of SByte"


    testProperty "Cos" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of SByte"

    testProperty "Cosh" <|
        fun (a:sbyte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of SByte"
]