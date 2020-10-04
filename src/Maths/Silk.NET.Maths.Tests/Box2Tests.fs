module Silk.NET.Maths.Tests.Box2Tests

open System
open Expecto
open FsCheck
open Silk.NET.Maths
open Silk.NET.Maths.Tests.Generators
 
let config = { FsCheckConfig.defaultConfig with arbitrary = [typeof<Vector2Gen>; typeof<Box2Gen>] }
let smallConfig = { config with maxTest = 10 }

[<Tests>]
let t = testList "Box2<float>" [
    testList "Constructor" [
        testPropertyWithConfig smallConfig "sets Max" <|
            fun (min:Vector2<float>, max:Vector2<float>) ->
                (min.X <= max.X && min.Y <= max.Y  && Double.IsNormal(min.X) && Double.IsNormal(min.Y) && Double.IsNormal(max.X) && Double.IsNormal(max.Y))
                ==> lazy(
                    let box = Box2(min, max)
                    box.Min = min)
                
        testPropertyWithConfig smallConfig "sets Min" <|
            fun (min:Vector2<float>, max:Vector2<float>) ->
                (min.X <= max.X && min.Y <= max.Y && Double.IsNormal(min.X) && Double.IsNormal(min.Y) && Double.IsNormal(max.X) && Double.IsNormal(max.Y))
                ==> lazy(
                    let box = Box2(min, max)
                    box.Max = max)
                
        testPropertyWithConfig config "min > max throws" <|
            fun (min:Vector2<float>, max:Vector2<float>) ->
                ((max.X < min.X) || (max.Y < min.Y))
                ==> lazy(Expect.throwsT<ArgumentOutOfRangeException> (fun () -> Box2(min, max) |> ignore) "min > max throws")
    ]
    
    testPropertyWithConfig config "Size" <|
        fun (box:Box2<float>) -> box.Size = (box.Max - box.Min)
        
    testPropertyWithConfig config "HalfSize" <|
        fun (box:Box2<float>) -> box.HalfSize = (box.Size / 2.0)
        
    testPropertyWithConfig config "Center" <|
        fun (box:Box2<float>) -> box.Center = (box.Min + box.HalfSize)
        
    testPropertyWithConfig config "WithMin valid" <|
            fun (box:Box2<float>, min:Vector2<float>) ->
                (min.X < box.Max.X && min.Y < box.Max.Y && Double.IsNormal(min.X) && Double.IsNormal(min.Y))
                ==> lazy (box.WithMin(min).Min = min)
                
    testPropertyWithConfig config "WithMin invalid" <|
        fun (box:Box2<float>, min:Vector2<float>) ->
            ((box.Max.X < min.X || box.Max.Y < min.Y) && Double.IsNormal(min.X) && Double.IsNormal(min.Y))
            ==> lazy(Expect.throwsT<ArgumentOutOfRangeException>(fun () -> box.WithMin(min) |> ignore) "min > max throws")
    
    testPropertyWithConfig config "WithMax valid" <|
            fun (box:Box2<float>, max:Vector2<float>) ->
                (max.X > box.Min.X && max.Y > box.Min.Y && Double.IsNormal(max.X) && Double.IsNormal(max.Y))
                ==> lazy (box.WithMax(max).Max = max)
                
    testPropertyWithConfig config "WithMax invalid" <|
        fun (box:Box2<float>, max:Vector2<float>) ->
            ((box.Min.X > max.X || box.Min.Y > max.Y) && Double.IsNormal(max.X) && Double.IsNormal(max.Y))
            ==> lazy(Expect.throwsT<ArgumentOutOfRangeException>(fun () -> box.WithMax(max) |> ignore) "min > max throws")

    testList "Contains" [
        testList "Point" [
            testList "OnEdge" [
                testList "Min" [
                    testPropertyWithConfig config "Boundary Inclusive" <|
                        fun (box:Box2<float>) ->
                            box.Contains(box.Min, boundaryInclusive = true) = true

                    testPropertyWithConfig config "Boundary Exclusive" <|
                        fun (box:Box2<float>) ->
                            box.Contains(box.Min, boundaryInclusive = false) = false
                ]
                testList "Max" [
                    testPropertyWithConfig config "Boundary Inclusive" <|
                        fun (box:Box2<float>) ->
                            box.Contains(box.Max, boundaryInclusive = true) = true

                    testPropertyWithConfig config "Boundary Exclusive" <|
                        fun (box:Box2<float>) ->
                            box.Contains(box.Max, boundaryInclusive = false) = false
                ]
            ]
            testPropertyWithConfig smallConfig "Random Point Inclusive" <|
                fun (box:Box2<float>, point:Vector2<float>) ->
                    box.Contains(point, boundaryInclusive = true)
                        = (point.X <= box.Max.X && point.X >= box.Min.X && point.Y <= box.Max.Y && point.Y >= box.Min.Y)
            testPropertyWithConfig smallConfig "Random Point Exclusive" <|
                fun (box:Box2<float>, point:Vector2<float>) ->
                    box.Contains(point, boundaryInclusive = false)
                        = (point.X < box.Max.X && point.X > box.Min.X && point.Y < box.Max.Y && point.Y > box.Min.Y)
        ]
        (*testList "Box" [
            testPropertyWithConfig config "Contains self" <| fun (box:Box2<float>) -> box.Contains(box) = true
            testPropertyWithConfig "Contains other" <|
                fun (box1:Box2<float>, box2:Box2<float>) -> box1
        ]*)
    ]
]
