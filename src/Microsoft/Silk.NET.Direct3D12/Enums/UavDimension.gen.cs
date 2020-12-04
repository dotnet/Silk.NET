// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_UAV_DIMENSION")]
    public enum UavDimension
    {
        [NativeName("Name", "D3D12_UAV_DIMENSION_UNKNOWN")]
        UavDimensionUnknown = 0x0,
        [NativeName("Name", "D3D12_UAV_DIMENSION_BUFFER")]
        UavDimensionBuffer = 0x1,
        [NativeName("Name", "D3D12_UAV_DIMENSION_TEXTURE1D")]
        UavDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D12_UAV_DIMENSION_TEXTURE1DARRAY")]
        UavDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D12_UAV_DIMENSION_TEXTURE2D")]
        UavDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D12_UAV_DIMENSION_TEXTURE2DARRAY")]
        UavDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D12_UAV_DIMENSION_TEXTURE3D")]
        UavDimensionTexture3D = 0x8,
    }
}
