// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvRayFlagsShift_")]
    public enum RayFlagsShift : int
    {
        [NativeName("Name", "SpvRayFlagsOpaqueKHRShift")]
        OpaqueKhrshift = 0x0,
        [NativeName("Name", "SpvRayFlagsNoOpaqueKHRShift")]
        NoOpaqueKhrshift = 0x1,
        [NativeName("Name", "SpvRayFlagsTerminateOnFirstHitKHRShift")]
        TerminateOnFirstHitKhrshift = 0x2,
        [NativeName("Name", "SpvRayFlagsSkipClosestHitShaderKHRShift")]
        SkipClosestHitShaderKhrshift = 0x3,
        [NativeName("Name", "SpvRayFlagsCullBackFacingTrianglesKHRShift")]
        CullBackFacingTrianglesKhrshift = 0x4,
        [NativeName("Name", "SpvRayFlagsCullFrontFacingTrianglesKHRShift")]
        CullFrontFacingTrianglesKhrshift = 0x5,
        [NativeName("Name", "SpvRayFlagsCullOpaqueKHRShift")]
        CullOpaqueKhrshift = 0x6,
        [NativeName("Name", "SpvRayFlagsCullNoOpaqueKHRShift")]
        CullNoOpaqueKhrshift = 0x7,
        [NativeName("Name", "SpvRayFlagsSkipTrianglesKHRShift")]
        SkipTrianglesKhrshift = 0x8,
        [NativeName("Name", "SpvRayFlagsSkipAABBsKHRShift")]
        SkipAabbsKhrshift = 0x9,
        [NativeName("Name", "SpvRayFlagsMax")]
        Max = 0x7FFFFFFF,
    }
}
