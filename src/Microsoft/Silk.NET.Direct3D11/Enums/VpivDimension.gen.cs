// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VPIV_DIMENSION")]
    public enum VpivDimension : int
    {
        [NativeName("Name", "D3D11_VPIV_DIMENSION_UNKNOWN")]
        VpivDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_VPIV_DIMENSION_TEXTURE2D")]
        VpivDimensionTexture2D = 0x1,
    }
}
