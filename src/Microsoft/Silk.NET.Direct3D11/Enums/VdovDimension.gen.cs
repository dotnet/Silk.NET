// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VDOV_DIMENSION")]
    public enum VdovDimension
    {
        [NativeName("Name", "D3D11_VDOV_DIMENSION_UNKNOWN")]
        VdovDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_VDOV_DIMENSION_TEXTURE2D")]
        VdovDimensionTexture2D = 0x1,
    }
}
