// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_UAV_DIMENSION")]
    public enum UavDimension : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_UNKNOWN")]
        UavDimensionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_BUFFER")]
        UavDimensionBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"Texture1D\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE1D")]
        UavDimensionTexture1D = 0x2,
        [Obsolete("Deprecated in favour of \"Texture1Darray\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE1DARRAY")]
        UavDimensionTexture1Darray = 0x3,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE2D")]
        UavDimensionTexture2D = 0x4,
        [Obsolete("Deprecated in favour of \"Texture2Darray\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE2DARRAY")]
        UavDimensionTexture2Darray = 0x5,
        [Obsolete("Deprecated in favour of \"Texture3D\"")]
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE3D")]
        UavDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D11_UAV_DIMENSION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D11_UAV_DIMENSION_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE1D")]
        Texture1D = 0x2,
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE1DARRAY")]
        Texture1Darray = 0x3,
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE2D")]
        Texture2D = 0x4,
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE2DARRAY")]
        Texture2Darray = 0x5,
        [NativeName("Name", "D3D11_UAV_DIMENSION_TEXTURE3D")]
        Texture3D = 0x8,
    }
}
