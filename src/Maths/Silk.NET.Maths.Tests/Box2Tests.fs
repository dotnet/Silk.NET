// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

module Silk.NET.Maths.Tests.Box2Tests

open System
open Expecto
open FsCheck
open Silk.NET.Maths

let config = { FsCheckConfig.defaultConfig with startSize = 50 }

let inline box2Tests<'T
    when ^T : struct
    and ^T : (new : unit -> ^T)
    and ^T :> ValueType
    and ^T :> IFormattable
    and ^T : comparison> =        
    testList (sprintf "Box2<%s> Tests" typedefof<'T>.Name) [
        testPropertyWithConfig config "constructor sets Min to min" <|
            fun (minX:^T, minY:^T, maxX:^T, maxY:^T) ->
                ((minX < maxX && minY < maxY)
                 ==> lazy (
                    let min = Vector2(minX, minY)
                    let max = Vector2(maxX, maxY)
                    let box = Box2(min, max)
                    box.Min = min))
                
        testPropertyWithConfig config "constructor sets Max to max" <|
            fun (minX:^T, minY:^T, maxX:^T, maxY:^T) ->
                ((minX < maxX && minY < maxY)
                 ==> lazy (
                    let min = Vector2(minX, minY)
                    let max = Vector2(maxX, maxY)
                    let box = Box2(min, max)
                    box.Max = max))
                
        testPropertyWithConfig config "constructor throws on invalid size" <|
            fun (minX:^T, minY:^T, maxX:^T, maxY:^T) ->
                ((minX > maxX || minY > maxY)
                 ==> lazy (
                    let min = Vector2(minX, minY)
                    let max = Vector2(maxX, maxY)
                    Expect.throwsT<ArgumentOutOfRangeException> <| (fun () -> Box2(min, max) |> ignore) <| "Box2(big, small) throws"))
                
        testPropertyWithConfig config "size returns size" <|
            fun (minX:^T, minY:^T, maxX:^T, maxY:^T) ->
                ((minX < maxX && minY < maxY)
                 ==> lazy (
                    let min = Vector2(minX, minY)
                    let max = Vector2(maxX, maxY)
                    let box = Box2(min, max)
                    box.Size = max - min))
                
                
        testPropertyWithConfig config "half size returns half the size" <|
            fun (minX:^T, minY:^T, maxX:^T, maxY:^T) ->
                 ((minX < maxX && minY < maxY)
                 ==> lazy (
                    let min = Vector2(minX, minY)
                    let max = Vector2(maxX, maxY)
                    let box = Box2(min, max)
                    box.HalfSize = (box.Size / Vector2(Scalar<'T>.Two))))
    ]
    
    
[<Tests>]
let uint8Box2Tests = box2Tests<uint8>


[<Tests>]
let int8Box2Tests = box2Tests<int8>


[<Tests>]
let uint16Box2Tests = box2Tests<uint16>


[<Tests>]
let int16Box2Tests = box2Tests<int16>
 
[<Tests>]
let uint32Box2Tests = box2Tests<uint32>


[<Tests>]
let int32Box2Tests = box2Tests<int32>

[<Tests>]
let uint64Box2Tests = box2Tests<uint64>


[<Tests>]
let int64Box2Tests = box2Tests<int64>


[<Tests>]
let float32Box2Tests = box2Tests<float32>


[<Tests>]
let floatBox2Tests = box2Tests<float>