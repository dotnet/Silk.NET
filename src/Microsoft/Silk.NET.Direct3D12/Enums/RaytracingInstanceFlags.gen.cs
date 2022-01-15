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
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_NONE")]
        RaytracingInstanceFlagNone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE")]
        RaytracingInstanceFlagTriangleCullDisable = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE")]
        RaytracingInstanceFlagTriangleFrontCounterclockwise = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE")]
        RaytracingInstanceFlagForceOpaque = 0x4,
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE")]
        RaytracingInstanceFlagForceNonOpaque = 0x8,
    }
}
