module Silk.NET.Maths.Tests.ByteScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar Byte Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<byte>.One 1uy "Scalar<byte>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<byte>.Two 2uy "Scalar<byte>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<byte>.Pi |> ignore) "Scalar<byte>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<byte>.Tau |> ignore) "Scalar<byte>.Tau throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<byte>.PositiveInfinity |> ignore) "Scalar<byte>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<byte>.NegativeInfinity |> ignore) "Scalar<byte>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<byte>()) 1uy "Scalar.One<byte>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<byte>()) 2uy "Scalar.Two<byte>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<byte>()) |> ignore) "Scalar.Pi<byte>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<byte>()) |> ignore) "Scalar.Tau<byte>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<byte>()) |> ignore) "Scalar.PositiveInfinity<byte>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<byte>()) |> ignore) "Scalar.NegativeInfinity<byte>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<byte>(a) = byte a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<byte>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<byte>()) "ThrowForNonFloatingPointType<byte> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<byte>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<byte> matches underlying" <|
        fun (a:byte) -> Scalar.SquareRoot<byte>(a) = byte (MathF.Sqrt(float32 a))
        
    testProperty "Add<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<byte> matches underlying" <|
        fun (a:byte, b:byte) -> (b <> 0uy) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<byte>(x, 0) throws DivideByZero" <|
        fun (a:byte) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0uy) |> ignore) "Divide<byte>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<byte> matches underlying" <|
        fun (a:byte, b:byte) -> (b <> 0uy) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<byte>(x, 0) throws DivideByZero" <|
        fun (a:byte) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0uy) |> ignore) "Mod<byte>(x, 0) throws DivideByZero" 
    
    testProperty "Min<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Min(a, b) = byte(MathF.Min(float32(a), float32(b)))

    testProperty "Max<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Max(a, b) = byte(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<byte> matches HLSL" <|
        fun (a:byte, b:byte, c:byte) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<byte> matches underlying" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Negate(a) |> ignore) "Byte cannot be negated"
        
    testProperty "Equal<byte> matches underlying" <|
        fun (a:byte, b:byte) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<byte> matches underlying" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of Byte"
        
    testProperty "Abs<byte> matches underlying" <|
        fun (a:byte) -> Scalar.Abs (a) = byte(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of Byte"
        
        
    testProperty "Sinh" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of Byte"


    testProperty "Asin" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of Byte"
        
        
    testProperty "Atan" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of Byte"
        
        
    testProperty "Atan2" <|
        fun (a:byte, b:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of Byte"


    testProperty "Cos" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of Byte"

    testProperty "Cosh" <|
        fun (a:byte) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of Byte"
]