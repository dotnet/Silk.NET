// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SRV_DIMENSION")]
    public enum SrvDimension : int
    {
        [NativeName("Name", "D3D12_SRV_DIMENSION_UNKNOWN")]
        SrvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D12_SRV_DIMENSION_BUFFER")]
        SrvDimensionBuffer = 0x1,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE1D")]
        SrvDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE1DARRAY")]
        SrvDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE2D")]
        SrvDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE2DARRAY")]
        SrvDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE2DMS")]
        SrvDimensionTexture2Dms = 0x6,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE2DMSARRAY")]
        SrvDimensionTexture2Dmsarray = 0x7,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURE3D")]
        SrvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURECUBE")]
        SrvDimensionTexturecube = 0x9,
        [NativeName("Name", "D3D12_SRV_DIMENSION_TEXTURECUBEARRAY")]
        SrvDimensionTexturecubearray = 0xA,
        [NativeName("Name", "D3D12_SRV_DIMENSION_RAYTRACING_ACCELERATION_STRUCTURE")]
        SrvDimensionRaytracingAccelerationStructure = 0xB,
    }
}
