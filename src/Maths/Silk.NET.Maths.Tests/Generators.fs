module Silk.NET.Maths.Tests.Generators

open System
open Expecto
open FsCheck
open Silk.NET.Maths

type public Vector2Gen() =
    static member Vector2() : Arbitrary<Vector2<'t>> =
        Arb.generate<'t>
        |> Gen.two
        |> Gen.map(fun (x) ->
            let (x, y) = x
            Vector2<'t> (x, y))
        |> Arb.fromGen
        
type public HalfGen() =
    static member Half() : Arbitrary<Half> =
        Arb.Default.Float32().Convert<float32, Half>((fun (a) -> Half.op_Explicit (a)), (fun (a) -> Half.op_Explicit (a)))
        
type public Box2Gen() =
    static member Box2() : Arbitrary<Box2<'t>> =
        Arb.generate<Vector2<'t>>
        |> Gen.two
        |> Gen.filter(fun (a) ->
            let (min, max) = a
            min.X <= max.X && min.Y <= max.Y  && Scalar.IsNormal(min.X) && Scalar.IsNormal(min.Y) && Scalar.IsNormal(max.X) && Scalar.IsNormal(max.Y))
        |> Gen.map(fun (a) ->
            let (min, max) = a
            Box2(min, max))
        |> Arb.fromGen