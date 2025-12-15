// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAGS")]
    public enum RaytracingGeometryFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NONE")]
        RaytracingGeometryFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE")]
        RaytracingGeometryFlagOpaque = 0x1,
        [Obsolete("Deprecated in favour of \"NoDuplicateAnyhitInvocation\"")]
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION")]
        RaytracingGeometryFlagNoDuplicateAnyhitInvocation = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE")]
        Opaque = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION")]
        NoDuplicateAnyhitInvocation = 0x2,
    }
}
