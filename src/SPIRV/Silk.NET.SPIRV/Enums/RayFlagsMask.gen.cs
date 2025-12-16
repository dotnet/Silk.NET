// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvRayFlagsMask_")]
    public enum RayFlagsMask : int
    {
        [NativeName("Name", "SpvRayFlagsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvRayFlagsOpaqueKHRMask")]
        OpaqueKhrMask = 0x1,
        [NativeName("Name", "SpvRayFlagsNoOpaqueKHRMask")]
        NoOpaqueKhrMask = 0x2,
        [NativeName("Name", "SpvRayFlagsTerminateOnFirstHitKHRMask")]
        TerminateOnFirstHitKhrMask = 0x4,
        [NativeName("Name", "SpvRayFlagsSkipClosestHitShaderKHRMask")]
        SkipClosestHitShaderKhrMask = 0x8,
        [NativeName("Name", "SpvRayFlagsCullBackFacingTrianglesKHRMask")]
        CullBackFacingTrianglesKhrMask = 0x10,
        [NativeName("Name", "SpvRayFlagsCullFrontFacingTrianglesKHRMask")]
        CullFrontFacingTrianglesKhrMask = 0x20,
        [NativeName("Name", "SpvRayFlagsCullOpaqueKHRMask")]
        CullOpaqueKhrMask = 0x40,
        [NativeName("Name", "SpvRayFlagsCullNoOpaqueKHRMask")]
        CullNoOpaqueKhrMask = 0x80,
        [NativeName("Name", "SpvRayFlagsSkipTrianglesKHRMask")]
        SkipTrianglesKhrMask = 0x100,
        [NativeName("Name", "SpvRayFlagsSkipAABBsKHRMask")]
        SkipAabBsKhrMask = 0x200,
        [NativeName("Name", "SpvRayFlagsForceOpacityMicromap2StateEXTMask")]
        ForceOpacityMicromap2StateExtMask = 0x400,
    }
}
