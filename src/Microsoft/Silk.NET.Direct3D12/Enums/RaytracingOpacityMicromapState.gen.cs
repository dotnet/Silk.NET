// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE")]
    public enum RaytracingOpacityMicromapState : int
    {
        [Obsolete("Deprecated in favour of \"Transparent\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_TRANSPARENT")]
        RaytracingOpacityMicromapStateTransparent = 0x0,
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_OPAQUE")]
        RaytracingOpacityMicromapStateOpaque = 0x1,
        [Obsolete("Deprecated in favour of \"UnknownTransparent\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_UNKNOWN_TRANSPARENT")]
        RaytracingOpacityMicromapStateUnknownTransparent = 0x2,
        [Obsolete("Deprecated in favour of \"UnknownOpaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_UNKNOWN_OPAQUE")]
        RaytracingOpacityMicromapStateUnknownOpaque = 0x3,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_TRANSPARENT")]
        Transparent = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_OPAQUE")]
        Opaque = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_UNKNOWN_TRANSPARENT")]
        UnknownTransparent = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_STATE_UNKNOWN_OPAQUE")]
        UnknownOpaque = 0x3,
    }
}
