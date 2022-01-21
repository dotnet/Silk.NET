// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VPOV_DIMENSION")]
    public enum VpovDimension : int
    {
        [NativeName("Name", "D3D11_VPOV_DIMENSION_UNKNOWN")]
        VpovDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_VPOV_DIMENSION_TEXTURE2D")]
        VpovDimensionTexture2D = 0x1,
        [NativeName("Name", "D3D11_VPOV_DIMENSION_TEXTURE2DARRAY")]
        VpovDimensionTexture2Darray = 0x2,
    }
}
