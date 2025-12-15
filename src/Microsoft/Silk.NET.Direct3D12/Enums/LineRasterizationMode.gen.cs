// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE")]
    public enum LineRasterizationMode : int
    {
        [Obsolete("Deprecated in favour of \"Aliased\"")]
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_ALIASED")]
        LineRasterizationModeAliased = 0x0,
        [Obsolete("Deprecated in favour of \"AlphaAntialiased\"")]
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED")]
        LineRasterizationModeAlphaAntialiased = 0x1,
        [Obsolete("Deprecated in favour of \"QuadrilateralWide\"")]
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE")]
        LineRasterizationModeQuadrilateralWide = 0x2,
        [Obsolete("Deprecated in favour of \"QuadrilateralNarrow\"")]
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_NARROW")]
        LineRasterizationModeQuadrilateralNarrow = 0x3,
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_ALIASED")]
        Aliased = 0x0,
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED")]
        AlphaAntialiased = 0x1,
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE")]
        QuadrilateralWide = 0x2,
        [NativeName("Name", "D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_NARROW")]
        QuadrilateralNarrow = 0x3,
    }
}
