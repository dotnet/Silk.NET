module Silk.NET.Maths.Tests.ScalarTests.Int32

open System
open Expecto
open Silk.NET.Maths
open FsCheck

[<Tests>]
let t = testList "Scalar Int32 Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<int32>.One 1l "Scalar<int32>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<int32>.Two 2l "Scalar<int32>.Two = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int32>.Pi |> ignore) "Scalar<int32>.Pi throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int32>.Tau |> ignore) "Scalar<int32>.Tau throws"
        testCase "HalfPi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int32>.HalfPi |> ignore) "Scalar<int32>.HalfPi throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int32>.PositiveInfinity |> ignore) "Scalar<int32>.PositiveInfinity throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar<int32>.NegativeInfinity |> ignore) "Scalar<int32>.NegativeInfinity throws"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<int32>()) 1l "Scalar.One<int32>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<int32>()) 2l "Scalar.Two<int32>() = 2"
        testCase "Pi" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Pi<int32>()) |> ignore) "Scalar.Pi<int32>() throws"
        testCase "Tau" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.Tau<int32>()) |> ignore) "Scalar.Tau<int32>() throws"
        testCase "PositiveInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.PositiveInfinity<int32>()) |> ignore) "Scalar.PositiveInfinity<int32>() throws"
        testCase "NegativeInfinity" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.NegativeInfinity<int32>()) |> ignore) "Scalar.NegativeInfinity<int32>() throws"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Scalar.As<int32>(a) = int32 a
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<int32>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowForNonFloatingPointType<int32>()) "ThrowForNonFloatingPointType<int32> throws NotSupportedException"
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<int32>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<int32> matches underlying" <|
        fun (a:int32) -> Scalar.SquareRoot<int32>(a) = int32 (MathF.Sqrt(float32 a))
        
    testProperty "Add<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Add(a, b) = a + b
        
    testProperty "Subtract<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Subtract(a, b) = a - b
    
    testProperty "Multiply<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Multiply(a, b) = a * b
    
    testProperty "Divide<int32> matches underlying" <|
        fun (a:int32, b:int32) -> (b <> 0l) ==> lazy ((Scalar.Divide(a, b)) = (a / b))
        
    testProperty "Divide<int32>(x, 0) throws DivideByZero" <|
        fun (a:int32) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Divide(a, 0l) |> ignore) "Divide<int32>(x, 0) throws DivideByZero" 
        
    testProperty "Mod<int32> matches underlying" <|
        fun (a:int32, b:int32) -> (b <> 0l) ==> lazy (Scalar.Mod(a, b) = a % b)

    testProperty "Mod<int32>(x, 0) throws DivideByZero" <|
        fun (a:int32) -> Expect.throwsT<DivideByZeroException> (fun () -> Scalar.Mod(a, 0l) |> ignore) "Mod<int32>(x, 0) throws DivideByZero" 
    
    testProperty "Min<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Min(a, b) = int32(MathF.Min(float32(a), float32(b)))

    testProperty "Max<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Max(a, b) = int32(MathF.Max(float32(a), float32(b)))

    testProperty "Larger<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<int32> matches HLSL" <|
        fun (a:int32, b:int32, c:int32) -> Scalar.Clamp(a, b, c) = Scalar.Min(Scalar.Max(a, b), c)
        
    testProperty "Negate<int32> matches underlying" <|
        fun (a:int32) -> Scalar.Negate(a) = int32 -a
        
    testProperty "Equal<int32> matches underlying" <|
        fun (a:int32, b:int32) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Acos<int32> matches underlying" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Acos(a) |> ignore) "Cannot find Acos of Int32"
        
    testProperty "Abs<int32> matches underlying" <|
        fun (a:int32) -> Scalar.Abs (a) = int32(MathF.Abs(float32(a)))
        
    testProperty "Sin" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sin(a) |> ignore) "Cannot find Sin of Int32"
        
        
    testProperty "Sinh" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Sinh(a) |> ignore) "Cannot find Sinh of Int32"


    testProperty "Asin" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Asin(a) |> ignore) "Cannot find Asin of Int32"
        
        
    testProperty "Atan" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan(a) |> ignore) "Cannot find Atan of Int32"
        
        
    testProperty "Atan2" <|
        fun (a:int32, b:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Atan2(a, b) |> ignore) "Cannot find Atan2 of Int32"


    testProperty "Cos" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cos(a) |> ignore) "Cannot find Cos of Int32"

    testProperty "Cosh" <|
        fun (a:int32) -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.Cosh(a) |> ignore) "Cannot find Cosh of Int32"
        
    testProperty "IsNormal" <| fun (a:int32) -> Expect.equal (Scalar.IsNormal<int32>(a)) true
]