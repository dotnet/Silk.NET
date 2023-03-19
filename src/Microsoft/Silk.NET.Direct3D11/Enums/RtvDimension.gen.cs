// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_RTV_DIMENSION")]
    public enum RtvDimension : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_UNKNOWN")]
        RtvDimensionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_BUFFER")]
        RtvDimensionBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"Texture1D\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE1D")]
        RtvDimensionTexture1D = 0x2,
        [Obsolete("Deprecated in favour of \"Texture1Darray\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE1DARRAY")]
        RtvDimensionTexture1Darray = 0x3,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2D")]
        RtvDimensionTexture2D = 0x4,
        [Obsolete("Deprecated in favour of \"Texture2Darray\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DARRAY")]
        RtvDimensionTexture2Darray = 0x5,
        [Obsolete("Deprecated in favour of \"Texture2Dms\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DMS")]
        RtvDimensionTexture2Dms = 0x6,
        [Obsolete("Deprecated in favour of \"Texture2Dmsarray\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY")]
        RtvDimensionTexture2Dmsarray = 0x7,
        [Obsolete("Deprecated in favour of \"Texture3D\"")]
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE3D")]
        RtvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D11_RTV_DIMENSION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D11_RTV_DIMENSION_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE1D")]
        Texture1D = 0x2,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE1DARRAY")]
        Texture1Darray = 0x3,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2D")]
        Texture2D = 0x4,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DARRAY")]
        Texture2Darray = 0x5,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DMS")]
        Texture2Dms = 0x6,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY")]
        Texture2Dmsarray = 0x7,
        [NativeName("Name", "D3D11_RTV_DIMENSION_TEXTURE3D")]
        Texture3D = 0x8,
    }
}
