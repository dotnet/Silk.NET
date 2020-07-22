module Silk.NET.Maths.Tests.ScalarTests.Double

open System
open Expecto
open Silk.NET.Maths
open FsCheck

(*
    you will see a lot of Double.Equals this is because Double.Equals(NaN, NaN) is true, while NaN = NaN is false
*)

[<Tests>]
let t = testList "Scalar Double Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<Double>.One 1.0 "Scalar<Double>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<Double>.Two 2.0 "Scalar<Double>.Two = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar<Double>.Pi) Math.PI "Scalar<Double>.Pi = Math.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar<Double>.Tau) Math.Tau "Scalar<Double>.Tau = Math.Tau"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar<Double>.PositiveInfinity) Double.PositiveInfinity "Scalar<Double>.PositiveInfinity = Double.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar<Double>.NegativeInfinity) Double.NegativeInfinity "Scalar<Double>.NegativeInfinity = Double.NegativeInfinity"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<Double>()) 1.0 "Scalar.One<Double>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<Double>()) 2.0 "Scalar.Two<Double>() = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar.Pi<Double>()) Math.PI "Scalar.Pi<Double>() = Math.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar.Tau<Double>()) Math.Tau "Scalar.Tau<Double>() = Math.Tau"
        testCase "HalfPi" <| fun () -> Expect.equal (Scalar.HalfPi<Double>()) (Math.PI / 2.0) "Scalar.Tau<Double>() = Math.PI / 2"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar.PositiveInfinity<Double>()) Double.PositiveInfinity "Scalar.PositiveInfinity<Double>() = Double.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar.NegativeInfinity<Double>()) Double.NegativeInfinity "Scalar.NegativeInfinity<Double>() = Double.NegativeInfinity"
    ]
    
    testProperty "As" <|
        fun (a:float32) -> Double.Equals(Scalar.As<Double>(a), double a)
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<Double>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Scalar.ThrowForNonFloatingPointType<Double>() // do nothing
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<Double>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    testProperty "SquareRoot<Double> matches underlying" <|
        fun (a:double) -> Double.Equals(Scalar.SquareRoot<Double>(a), Math.Sqrt(a))
        
    testProperty "Add<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Add(a, b), a + b)
        
    testProperty "Subtract<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Subtract(a, b), a - b)
    
    testProperty "Multiply<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Multiply(a, b), a * b)
    
    testProperty "Divide<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Divide(a, b), (a / b))
        
    testProperty "Mod<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Mod(a, b), a % b)
    
    testProperty "Min<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Min(a, b), Math.Min(a, b))

    testProperty "Max<Double> matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Max(a, b), Math.Max(a, b))

    testProperty "Larger<Double> matches underlying" <|
        fun (a:double, b:double) -> Scalar.Larger(a, b) = (a > b)
        
    testProperty "Smaller<Double> matches underlying" <|
        fun (a:double, b:double) -> Scalar.Smaller(a, b) = (a < b)
        
    testProperty "LargerEquals<Double> matches underlying" <|
        fun (a:double, b:double) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    testProperty "SmallerEquals<Double> matches underlying" <|
        fun (a:double, b:double) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    testProperty "Clamp<Double> matches HLSL" <|
        fun (a:double, b:double, c:double) -> Double.Equals(Scalar.Clamp(a, b, c), Scalar.Min(Scalar.Max(a, b), c))
        
    testProperty "Negate<Double> matches underlying" <|
        fun (a:double) -> Double.Equals(Scalar.Negate(a), -a)
        
    testProperty "Equal<Double> matches underlying" <|
        fun (a:double, b:double) -> Scalar.Equal(a, b) = (a = b)
        
    testProperty "Abs<Double> matches underlying" <|
        fun (a:double) -> Double.Equals(Scalar.Abs (a), Math.Abs(a))
        
    testProperty "Sin matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Sin a), (Math.Sin a))
        
    testProperty "Sinh matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Sinh a), (Math.Sinh a))

    testProperty "Asin matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Asin a), (Math.Asin a))
        
    testProperty "Atan matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Atan a), (Math.Atan a))
        
    testProperty "Cos matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Cos a), (Math.Cos a))

    testProperty "Acos matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Acos a), (Math.Acos a))  
        
    testProperty "Cosh matches underlying" <|
        fun (a:double) -> Double.Equals((Scalar.Cosh a), (Math.Cosh a))
        
    testProperty "Atan2 matches underlying" <|
        fun (a:double, b:double) -> Double.Equals(Scalar.Atan2(a, b), Math.Atan2(a, b))
        
    testProperty "IsNormal" <| fun (a:Double) -> Expect.equal (Scalar.IsNormal<Double>(a)) (Double.IsNormal a)
]