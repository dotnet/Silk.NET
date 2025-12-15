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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_NONE")]
        RayFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ForceOpaque\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_OPAQUE")]
        RayFlagForceOpaque = 0x1,
        [Obsolete("Deprecated in favour of \"ForceNonOpaque\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_NON_OPAQUE")]
        RayFlagForceNonOpaque = 0x2,
        [Obsolete("Deprecated in favour of \"AcceptFirstHitAndEndSearch\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH")]
        RayFlagAcceptFirstHitAndEndSearch = 0x4,
        [Obsolete("Deprecated in favour of \"SkipClosestHitShader\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER")]
        RayFlagSkipClosestHitShader = 0x8,
        [Obsolete("Deprecated in favour of \"CullBackFacingTriangles\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES")]
        RayFlagCullBackFacingTriangles = 0x10,
        [Obsolete("Deprecated in favour of \"CullFrontFacingTriangles\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES")]
        RayFlagCullFrontFacingTriangles = 0x20,
        [Obsolete("Deprecated in favour of \"CullOpaque\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_OPAQUE")]
        RayFlagCullOpaque = 0x40,
        [Obsolete("Deprecated in favour of \"CullNonOpaque\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_NON_OPAQUE")]
        RayFlagCullNonOpaque = 0x80,
        [Obsolete("Deprecated in favour of \"SkipTriangles\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_TRIANGLES")]
        RayFlagSkipTriangles = 0x100,
        [Obsolete("Deprecated in favour of \"SkipProceduralPrimitives\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES")]
        RayFlagSkipProceduralPrimitives = 0x200,
        [Obsolete("Deprecated in favour of \"ForceOmm2State\"")]
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_OMM_2_STATE")]
        RayFlagForceOmm2State = 0x400,
        [NativeName("Name", "D3D12_RAY_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_OPAQUE")]
        ForceOpaque = 0x1,
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_NON_OPAQUE")]
        ForceNonOpaque = 0x2,
        [NativeName("Name", "D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH")]
        AcceptFirstHitAndEndSearch = 0x4,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER")]
        SkipClosestHitShader = 0x8,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES")]
        CullBackFacingTriangles = 0x10,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES")]
        CullFrontFacingTriangles = 0x20,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_OPAQUE")]
        CullOpaque = 0x40,
        [NativeName("Name", "D3D12_RAY_FLAG_CULL_NON_OPAQUE")]
        CullNonOpaque = 0x80,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_TRIANGLES")]
        SkipTriangles = 0x100,
        [NativeName("Name", "D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES")]
        SkipProceduralPrimitives = 0x200,
        [NativeName("Name", "D3D12_RAY_FLAG_FORCE_OMM_2_STATE")]
        ForceOmm2State = 0x400,
    }
}
