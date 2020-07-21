module Silk.NET.Maths.Tests.UInt32ScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar UInt32 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<uint32>.One 1ul "Scalar<uint32>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<uint32>.Two 2ul "Scalar<uint32>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint32>.Pi |> ignore) "Scalar<uint32>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint32>.Tau |> ignore) "Scalar<uint32>.Tau throws"
        testCase "HalfPi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint32>.HalfPi |> ignore) "Scalar<uint32>.HalfPi throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint32>.PositiveInfinity |> ignore) "Scalar<uint32>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<uint32>.NegativeInfinity |> ignore) "Scalar<uint32>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<uint32>()) 1ul "Scalar.One<uint32>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<uint32>()) 2ul "Scalar.Two<uint32>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<uint32>()) |> ignore) "Scalar.Pi<uint32>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<uint32>()) |> ignore) "Scalar.Tau<uint32>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<uint32>()) |> ignore) "Scalar.PositiveInfinity<uint32>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<uint32>()) |> ignore) "Scalar.NegativeInfinity<uint32>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<uint32>(a) = uint32 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<uint32>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<uint32>()) "ThrowForNonFloatingPointType<uint32> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<uint32>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<uint32> matches underlying" <|
        fun (a:uint32) -> Scalar.SquareRoot<uint32>(a) = uint32 (MathF.Sqrt(float32 a))
        
    testProperty "Add<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> (b <> 0ul) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<uint32>(x, 0) throws DivideByZero" <|
        fun (a:uint32) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0ul) |> ignore) "Divide<uint32>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> (b <> 0ul) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<uint32>(x, 0) throws DivideByZero" <|
        fun (a:uint32) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0ul) |> ignore) "Mod<uint32>(x, 0) throws DivideByZero" 
    
    testProperty "Min<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Min(a, b) = uint32(MathF.Min(float32(a), float32(b)))

    testProperty "Max<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Max(a, b) = uint32(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<uint32> matches HLSL" <|
        fun (a:uint32, b:uint32, c:uint32) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<uint32> matches underlying" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Negate(a) |> ignore) "UInt32 cannot be negated"
        
    testProperty "Equal<uint32> matches underlying" <|
        fun (a:uint32, b:uint32) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<uint32> matches underlying" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of UInt32"
        
    testProperty "Abs<uint32> matches underlying" <|
        fun (a:uint32) -> Scalar.Abs (a) = uint32(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of UInt32"
        
        
    testProperty "Sinh" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of UInt32"


    testProperty "Asin" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of UInt32"
        
        
    testProperty "Atan" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of UInt32"
        
        
    testProperty "Atan2" <|
        fun (a:uint32, b:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of UInt32"


    testProperty "Cos" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of UInt32"

    testProperty "Cosh" <|
        fun (a:uint32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of UInt32"
]