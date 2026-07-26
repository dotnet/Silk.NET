// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT")]
    public enum RaytracingOpacityMicromapFormat : int
    {
        [Obsolete("Deprecated in favour of \"OC12State\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT_OC1_2_STATE")]
        RaytracingOpacityMicromapFormatOC12State = 0x1,
        [Obsolete("Deprecated in favour of \"OC14State\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT_OC1_4_STATE")]
        RaytracingOpacityMicromapFormatOC14State = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT_OC1_2_STATE")]
        OC12State = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT_OC1_4_STATE")]
        OC14State = 0x2,
    }
}
