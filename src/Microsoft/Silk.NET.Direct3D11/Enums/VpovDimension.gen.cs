// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VPOV_DIMENSION")]
    public enum VpovDimension
    {
        [NativeName("Name", "D3D11_VPOV_DIMENSION_UNKNOWN")]
        VpovDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_VPOV_DIMENSION_TEXTURE2D")]
        VpovDimensionTexture2D = 0x1,
        [NativeName("Name", "D3D11_VPOV_DIMENSION_TEXTURE2DARRAY")]
        VpovDimensionTexture2Darray = 0x2,
    }
}
