// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RAY_FLAGS")]
    public enum RayFlags : int
    {
        [NativeName("Name", "D3D12_RAY_FLAG_NONE")]
        RayFlagNone = 0x0,
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_OPAQUE")]
        RayFlagForceOpaque = 0x1,
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_NON_OPAQUE")]
        RayFlagForceNonOpaque = 0x2,
        [NativeName("Name", "D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH")]
        RayFlagAcceptFirstHitAndEndSearch = 0x4,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER")]
        RayFlagSkipClosestHitShader = 0x8,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES")]
        RayFlagCullBackFacingTriangles = 0x10,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES")]
        RayFlagCullFrontFacingTriangles = 0x20,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_OPAQUE")]
        RayFlagCullOpaque = 0x40,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_NON_OPAQUE")]
        RayFlagCullNonOpaque = 0x80,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_TRIANGLES")]
        RayFlagSkipTriangles = 0x100,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES")]
        RayFlagSkipProceduralPrimitives = 0x200,
    }
}
