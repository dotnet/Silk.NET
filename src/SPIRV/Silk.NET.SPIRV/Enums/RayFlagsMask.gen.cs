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
        OpaqueKhrmask = 0x1,
        [NativeName("Name", "SpvRayFlagsNoOpaqueKHRMask")]
        NoOpaqueKhrmask = 0x2,
        [NativeName("Name", "SpvRayFlagsTerminateOnFirstHitKHRMask")]
        TerminateOnFirstHitKhrmask = 0x4,
        [NativeName("Name", "SpvRayFlagsSkipClosestHitShaderKHRMask")]
        SkipClosestHitShaderKhrmask = 0x8,
        [NativeName("Name", "SpvRayFlagsCullBackFacingTrianglesKHRMask")]
        CullBackFacingTrianglesKhrmask = 0x10,
        [NativeName("Name", "SpvRayFlagsCullFrontFacingTrianglesKHRMask")]
        CullFrontFacingTrianglesKhrmask = 0x20,
        [NativeName("Name", "SpvRayFlagsCullOpaqueKHRMask")]
        CullOpaqueKhrmask = 0x40,
        [NativeName("Name", "SpvRayFlagsCullNoOpaqueKHRMask")]
        CullNoOpaqueKhrmask = 0x80,
        [NativeName("Name", "SpvRayFlagsSkipTrianglesKHRMask")]
        SkipTrianglesKhrmask = 0x100,
        [NativeName("Name", "SpvRayFlagsSkipAABBsKHRMask")]
        SkipAabbsKhrmask = 0x200,
        [NativeName("Name", "SpvRayFlagsForceOpacityMicromap2StateEXTMask")]
        ForceOpacityMicromap2StateExtmask = 0x400,
    }
}
