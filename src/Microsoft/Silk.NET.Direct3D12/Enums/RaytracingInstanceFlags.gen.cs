// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAGS")]
    public enum RaytracingInstanceFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_NONE")]
        RaytracingInstanceFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"TriangleCullDisable\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE")]
        RaytracingInstanceFlagTriangleCullDisable = 0x1,
        [Obsolete("Deprecated in favour of \"TriangleFrontCounterclockwise\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE")]
        RaytracingInstanceFlagTriangleFrontCounterclockwise = 0x2,
        [Obsolete("Deprecated in favour of \"ForceOpaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE")]
        RaytracingInstanceFlagForceOpaque = 0x4,
        [Obsolete("Deprecated in favour of \"ForceNonOpaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE")]
        RaytracingInstanceFlagForceNonOpaque = 0x8,
        [Obsolete("Deprecated in favour of \"ForceOmm2State\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OMM_2_STATE")]
        RaytracingInstanceFlagForceOmm2State = 0x10,
        [Obsolete("Deprecated in favour of \"DisableOmms\"")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_DISABLE_OMMS")]
        RaytracingInstanceFlagDisableOmms = 0x20,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE")]
        TriangleCullDisable = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE")]
        TriangleFrontCounterclockwise = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE")]
        ForceOpaque = 0x4,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE")]
        ForceNonOpaque = 0x8,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OMM_2_STATE")]
        ForceOmm2State = 0x10,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_DISABLE_OMMS")]
        DisableOmms = 0x20,
    }
}
