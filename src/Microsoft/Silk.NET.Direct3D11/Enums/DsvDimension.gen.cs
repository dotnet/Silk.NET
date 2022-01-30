// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_DSV_DIMENSION")]
    public enum DsvDimension : int
    {
        [NativeName("Name", "D3D11_DSV_DIMENSION_UNKNOWN")]
        DsvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE1D")]
        DsvDimensionTexture1D = 0x1,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE1DARRAY")]
        DsvDimensionTexture1Darray = 0x2,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE2D")]
        DsvDimensionTexture2D = 0x3,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE2DARRAY")]
        DsvDimensionTexture2Darray = 0x4,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE2DMS")]
        DsvDimensionTexture2Dms = 0x5,
        [NativeName("Name", "D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY")]
        DsvDimensionTexture2Dmsarray = 0x6,
    }
}
