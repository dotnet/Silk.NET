// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VPIV_DIMENSION")]
    public enum VpivDimension : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D11_VPIV_DIMENSION_UNKNOWN")]
        VpivDimensionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D11_VPIV_DIMENSION_TEXTURE2D")]
        VpivDimensionTexture2D = 0x1,
        [NativeName("Name", "D3D11_VPIV_DIMENSION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D11_VPIV_DIMENSION_TEXTURE2D")]
        Texture2D = 0x1,
    }
}
