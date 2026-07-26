// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX")]
    public enum RaytracingOpacityMicromapSpecialIndex : int
    {
        [Obsolete("Deprecated in favour of \"Transparent\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT")]
        RaytracingOpacityMicromapSpecialIndexFullyTransparent = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE")]
        RaytracingOpacityMicromapSpecialIndexFullyOpaque = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [Obsolete("Deprecated in favour of \"UnknownTransparent\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT")]
        RaytracingOpacityMicromapSpecialIndexFullyUnknownTransparent = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [Obsolete("Deprecated in favour of \"UnknownOpaque\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE")]
        RaytracingOpacityMicromapSpecialIndexFullyUnknownOpaque = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT")]
        Transparent = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE")]
        Opaque = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT")]
        UnknownTransparent = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE")]
        UnknownOpaque = unchecked((int) 0xFFFFFFFFFFFFFFFC),
    }
}
