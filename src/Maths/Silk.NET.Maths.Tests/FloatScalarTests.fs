module Silk.NET.Maths.Tests.SingleScalarTests

open System
open Expecto
open Silk.NET.Maths
open FsCheck

(*
    you will see a lot of Single.Equals this is because Single.Equals(NaN, NaN) is true, while NaN = NaN is false
*)

[<Tests>]
let t = testList "Scalar Single Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<Single>.One 1.0f "Scalar<Single>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<Single>.Two 2.0f "Scalar<Single>.Two = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar<Single>.Pi) MathF.PI "Scalar<Single>.Pi = MathF.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar<Single>.Tau) MathF.Tau "Scalar<Single>.Tau = MathF.Tau"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar<Single>.PositiveInfinity) Single.PositiveInfinity "Scalar<Single>.PositiveInfinity = Single.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar<Single>.NegativeInfinity) Single.NegativeInfinity "Scalar<Single>.NegativeInfinity = Single.NegativeInfinity"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<Single>()) 1.0f "Scalar.One<Single>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<Single>()) 2.0f "Scalar.Two<Single>() = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar.Pi<Single>()) MathF.PI "Scalar.Pi<Single>() = MathF.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar.Tau<Single>()) MathF.Tau "Scalar.Tau<Single>() = MathF.Tau"
        testCase "HalfPi" <| fun () -> Expect.equal (Scalar.HalfPi<Single>()) (MathF.PI / 2.0f) "Scalar.Tau<Single>() = MathF.PI / 2"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar.PositiveInfinity<Single>()) Single.PositiveInfinity "Scalar.PositiveInfinity<Single>() = Single.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar.NegativeInfinity<Single>()) Single.NegativeInfinity "Scalar.NegativeInfinity<Single>() = Single.NegativeInfinity"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Single.Equals(Scalar.As<Single>(a), a)
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<Single>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Scalar.ThrowForNonFloatingPointType<Single>() // do nothing
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<Single>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<Single> matches underlying" <|
        fun (a:float32) -> Single.Equals(Scalar.SquareRoot<Single>(a), MathF.Sqrt(a))
        
    testProperty "Add<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Add(a, b), a + b)
        
    testProperty "Subtract<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Subtract(a, b), a - b)
    
    testProperty "Multiply<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Multiply(a, b), a * b)
    
    testProperty "Divide<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Divide(a, b), (a / b))
        
    testProperty "Mod<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Mod(a, b), a % b)
    
    testProperty "Min<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Min(a, b), MathF.Min(a, b))

    testProperty "Max<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Max(a, b), MathF.Max(a, b))

    testProperty "Larger<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<Single> matches HLSL" <|
        fun (a:float32, b:float32, c:float32) -> Single.Equals(Scalar.Clamp(a, b, c), Scalar.Min(Scalar.Max(a, b), c))
        
    testProperty "Negate<Single> matches underlying" <|
        fun (a:float32) -> Single.Equals(Scalar.Negate(a), -a)
        
    testProperty "Equal<Single> matches underlying" <|
        fun (a:float32, b:float32) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Abs<Single> matches underlying" <|
        fun (a:float32) -> Single.Equals(Scalar.Abs (a), MathF.Abs(a))
        
    testProperty "Sin matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Sin a), (MathF.Sin a))
        
    testProperty "Sinh matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Sinh a), (MathF.Sinh a))

    testProperty "Asin matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Asin a), (MathF.Asin a))
        
    testProperty "Atan matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Atan a), (MathF.Atan a))
        
    testProperty "Cos matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Cos a), (MathF.Cos a))

    testProperty "Acos matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Acos a), (MathF.Acos a))  
        
    testProperty "Cosh matches underlying" <|
        fun (a:float32) -> Single.Equals((Scalar.Cosh a), (MathF.Cosh a))
        
    testProperty "Atan2 matches underlying" <|
        fun (a:float32, b:float32) -> Single.Equals(Scalar.Atan2(a, b), MathF.Atan2(a, b))
]