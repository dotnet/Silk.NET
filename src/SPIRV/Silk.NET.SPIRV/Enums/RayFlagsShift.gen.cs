// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvRayFlagsShift_")]
    public enum RayFlagsShift : int
    {
        [NativeName("Name", "SpvRayFlagsOpaqueKHRShift")]
        OpaqueKhrShift = 0x0,
        [NativeName("Name", "SpvRayFlagsNoOpaqueKHRShift")]
        NoOpaqueKhrShift = 0x1,
        [NativeName("Name", "SpvRayFlagsTerminateOnFirstHitKHRShift")]
        TerminateOnFirstHitKhrShift = 0x2,
        [NativeName("Name", "SpvRayFlagsSkipClosestHitShaderKHRShift")]
        SkipClosestHitShaderKhrShift = 0x3,
        [NativeName("Name", "SpvRayFlagsCullBackFacingTrianglesKHRShift")]
        CullBackFacingTrianglesKhrShift = 0x4,
        [NativeName("Name", "SpvRayFlagsCullFrontFacingTrianglesKHRShift")]
        CullFrontFacingTrianglesKhrShift = 0x5,
        [NativeName("Name", "SpvRayFlagsCullOpaqueKHRShift")]
        CullOpaqueKhrShift = 0x6,
        [NativeName("Name", "SpvRayFlagsCullNoOpaqueKHRShift")]
        CullNoOpaqueKhrShift = 0x7,
        [NativeName("Name", "SpvRayFlagsSkipTrianglesKHRShift")]
        SkipTrianglesKhrShift = 0x8,
        [NativeName("Name", "SpvRayFlagsSkipAABBsKHRShift")]
        SkipAabBsKhrShift = 0x9,
        [NativeName("Name", "SpvRayFlagsForceOpacityMicromap2StateEXTShift")]
        ForceOpacityMicromap2StateExtShift = 0xA,
        [NativeName("Name", "SpvRayFlagsMax")]
        Max = 0x7FFFFFFF,
    }
}
