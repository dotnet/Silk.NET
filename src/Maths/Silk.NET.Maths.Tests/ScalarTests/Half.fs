module Silk.NET.Maths.Tests.ScalarTests.Half

open System
open Expecto
open Silk.NET.Maths
open FsCheck

(*
    you will see a lot of Half.Equals this is because Half.Equals(NaN, NaN) is true, while NaN = NaN is false
*)

type HalfGen() =
    static member Half() : Arbitrary<Half> =
        Arb.Default.Float32().Convert<float32, Half>((fun (a) -> Half.op_Explicit (a)), (fun (a) -> Half.op_Explicit (a)))
        
let config = { FsCheckConfig.defaultConfig with arbitrary = [typeof<HalfGen>] }

[<Tests>]
let t = testList "Scalar Half Tests" [
    testList "Generic Helper" [
        testCase "One" <| fun () -> Expect.equal Scalar<Half>.One (Half.op_Explicit 1.0f) "Scalar<Half>.One = 1"
        testCase "Two" <| fun () -> Expect.equal Scalar<Half>.Two (Half.op_Explicit 2.0f) "Scalar<Half>.Two = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar<Half>.Pi) (Half.op_Explicit MathF.PI) "Scalar<Half>.Pi = MathF.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar<Half>.Tau) (Half.op_Explicit MathF.Tau) "Scalar<Half>.Tau = MathF.Tau"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar<Half>.PositiveInfinity) Half.PositiveInfinity "Scalar<Half>.PositiveInfinity = Half.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar<Half>.NegativeInfinity) Half.NegativeInfinity "Scalar<Half>.NegativeInfinity = Half.NegativeInfinity"
    ]
    
    testList "Constants" [
        testCase "One" <| fun () -> Expect.equal (Scalar.One<Half>()) (Half.op_Explicit 1.0f) "Scalar.One<Half>() = 1"
        testCase "Two" <| fun () -> Expect.equal (Scalar.Two<Half>()) (Half.op_Explicit 2.0f) "Scalar.Two<Half>() = 2"
        testCase "Pi" <| fun () -> Expect.equal (Scalar.Pi<Half>()) (Half.op_Explicit MathF.PI) "Scalar.Pi<Half>() = MathF.PI"
        testCase "Tau" <| fun () -> Expect.equal (Scalar.Tau<Half>()) (Half.op_Explicit MathF.Tau) "Scalar.Tau<Half>() = MathF.Tau"
        testCase "HalfPi" <| fun () -> Expect.equal (Scalar.HalfPi<Half>()) (Half.op_Explicit (MathF.PI / 2.0f)) "Scalar.Tau<Half>() = MathF.PI / 2"
        testCase "PositiveInfinity" <| fun () -> Expect.equal (Scalar.PositiveInfinity<Half>()) Half.PositiveInfinity "Scalar.PositiveInfinity<Half>() = Half.PositiveInfinity"
        testCase "NegativeInfinity" <| fun () -> Expect.equal (Scalar.NegativeInfinity<Half>()) Half.NegativeInfinity "Scalar.NegativeInfinity<Half>() = Half.NegativeInfinity"
    ]
    
    // ptestPropertyWithConfig config "As" <|
    //    fun (a:float32) -> Half.Equals(Scalar.As<Half>(a), Half.op_Explicit a)
    
    testList "Throw Helpers" [
        testCase "ThrowInvalidType" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> (Scalar.ThrowInvalidType())) "ThrowInvalidType throws NotSupportedException"
        testCase "ThrowForUnsupportedBaseType" <| fun () -> Scalar.ThrowForUnsupportedBaseType<Half>()
        testCase "ThrowForNonFloatingPointType" <| fun () -> Scalar.ThrowForNonFloatingPointType<Half>() // do nothing
        testCase "ThrowNotSupportedByUnderlying" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowNotSupportedByUnderlying<Half>()) "ThrowNotSupportedByUnderlying throws NotSupportedException"
        testCase "ThrowIndexOutOfRange" <| fun () -> Expect.throwsT<IndexOutOfRangeException> (fun () -> Scalar.ThrowIndexOutOfRange()) "ThrowIndexOutOfRange throws IndexOutOfRangeException"
        testCase "ThrowVectorTTooSmall" <| fun () -> Expect.throwsT<NotSupportedException> (fun () -> Scalar.ThrowVectorTTooSmall()) "ThrowVectorTTooSmall throws NotSupportedException"
    ]
    
    (*ptestPropertyWithConfig config "SquareRoot<Half> matches underlying" <|
        fun (a:Half) -> Half.Equals(Scalar.SquareRoot<Half>(a), a |> float32 |> MathF.Sqrt |> Half.op_Explicit)
        
    ptestPropertyWithConfig config "Add<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Add(a, b), (float32 a) + (float32 b))
        
    ptestPropertyWithConfig config "Subtract<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Subtract(a, b), (float32 a) - (float32 b))
    
    ptestPropertyWithConfig config "Multiply<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Multiply(a, b), (float32 a) * (float32 b))
    
    ptestPropertyWithConfig config "Divide<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Divide(a, b), ((float32 a) / (float32 b)))
        
    ptestPropertyWithConfig config "Mod<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Mod(a, b), (float32 a) % (float32 b))
    
    ptestPropertyWithConfig config "Min<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Min(a, b), MathF.Min(float32 a, float32 b))

    ptestPropertyWithConfig config "Max<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Max(a, b), MathF.Max(float32 a, float32 b))

    ptestPropertyWithConfig config "Larger<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Scalar.Larger(a, b) = (a > b)
        
    ptestPropertyWithConfig config "Smaller<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Scalar.Smaller(a, b) = (a < b)
        
    ptestPropertyWithConfig config "LargerEquals<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Scalar.LargerEquals(a, b) = (a >= b)
        
    ptestPropertyWithConfig config "SmallerEquals<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Scalar.SmallerEquals(a, b) = (a <= b)
        
    ptestPropertyWithConfig config "Clamp<Half> matches HLSL" <|
        fun (a:Half, b:Half, c:Half) -> Half.Equals(Scalar.Clamp(a, b, c), Scalar.Min(Scalar.Max(a, b), c))
        
    ptestPropertyWithConfig config "Negate<Half> matches underlying" <|
        fun (a:Half) -> Half.Equals(Scalar.Negate(a), -(float32 a))
        
    ptestPropertyWithConfig config "Equal<Half> matches underlying" <|
        fun (a:Half, b:Half) -> Scalar.Equal(a, b) = (a = b)
        
    ptestPropertyWithConfig config "Abs<Half> matches underlying" <|
        fun (a:Half) -> Half.Equals(Scalar.Abs (a), MathF.Abs(float32 a))
        
    ptestPropertyWithConfig config "Sin matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Sin a), (MathF.Sin (float32 a)))
        
    ptestPropertyWithConfig config "Sinh matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Sinh a), (MathF.Sinh (float32 a)))

    ptestPropertyWithConfig config "Asin matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Asin a), (MathF.Asin (float32 a)))
        
    ptestPropertyWithConfig config "Atan matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Atan a), (MathF.Atan (float32 a)))
        
    ptestPropertyWithConfig config "Cos matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Cos a), (MathF.Cos (float32 a)))

    ptestPropertyWithConfig config "Acos matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Acos a), (MathF.Acos (float32 a)))
        
    ptestPropertyWithConfig config "Cosh matches underlying" <|
        fun (a:Half) -> Half.Equals((Scalar.Cosh a), (MathF.Cosh (float32 a)))
        
    ptestPropertyWithConfig config "Atan2 matches underlying" <|
        fun (a:Half, b:Half) -> Half.Equals(Scalar.Atan2(a, b), MathF.Atan2(float32 a, float32 b))*)
        
    testPropertyWithConfig config "IsNormal" <| fun (a:Half) -> Expect.equal (Scalar.IsNormal<Half>(a)) (Half.IsNormal a)
]