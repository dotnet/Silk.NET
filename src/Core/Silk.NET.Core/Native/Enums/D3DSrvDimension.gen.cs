// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_SRV_DIMENSION")]
    public enum D3DSrvDimension : int
    {
        [NativeName("Name", "D3D_SRV_DIMENSION_UNKNOWN")]
        D3DSrvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D_SRV_DIMENSION_BUFFER")]
        D3DSrvDimensionBuffer = 0x1,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE1D")]
        D3DSrvDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE1DARRAY")]
        D3DSrvDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE2D")]
        D3DSrvDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE2DARRAY")]
        D3DSrvDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE2DMS")]
        D3DSrvDimensionTexture2Dms = 0x6,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE2DMSARRAY")]
        D3DSrvDimensionTexture2Dmsarray = 0x7,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURE3D")]
        D3DSrvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURECUBE")]
        D3DSrvDimensionTexturecube = 0x9,
        [NativeName("Name", "D3D_SRV_DIMENSION_TEXTURECUBEARRAY")]
        D3DSrvDimensionTexturecubearray = 0xA,
        [NativeName("Name", "D3D_SRV_DIMENSION_BUFFEREX")]
        D3DSrvDimensionBufferex = 0xB,
        [NativeName("Name", "D3D10_SRV_DIMENSION_UNKNOWN")]
        D3D10SrvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D10_SRV_DIMENSION_BUFFER")]
        D3D10SrvDimensionBuffer = 0x1,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE1D")]
        D3D10SrvDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE1DARRAY")]
        D3D10SrvDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE2D")]
        D3D10SrvDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE2DARRAY")]
        D3D10SrvDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE2DMS")]
        D3D10SrvDimensionTexture2Dms = 0x6,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY")]
        D3D10SrvDimensionTexture2Dmsarray = 0x7,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURE3D")]
        D3D10SrvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D10_SRV_DIMENSION_TEXTURECUBE")]
        D3D10SrvDimensionTexturecube = 0x9,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_UNKNOWN")]
        D3D101SrvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_BUFFER")]
        D3D101SrvDimensionBuffer = 0x1,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE1D")]
        D3D101SrvDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY")]
        D3D101SrvDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE2D")]
        D3D101SrvDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY")]
        D3D101SrvDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE2DMS")]
        D3D101SrvDimensionTexture2Dms = 0x6,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY")]
        D3D101SrvDimensionTexture2Dmsarray = 0x7,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURE3D")]
        D3D101SrvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURECUBE")]
        D3D101SrvDimensionTexturecube = 0x9,
        [NativeName("Name", "D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY")]
        D3D101SrvDimensionTexturecubearray = 0xA,
        [NativeName("Name", "D3D11_SRV_DIMENSION_UNKNOWN")]
        D3D11SrvDimensionUnknown = 0x0,
        [NativeName("Name", "D3D11_SRV_DIMENSION_BUFFER")]
        D3D11SrvDimensionBuffer = 0x1,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE1D")]
        D3D11SrvDimensionTexture1D = 0x2,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE1DARRAY")]
        D3D11SrvDimensionTexture1Darray = 0x3,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE2D")]
        D3D11SrvDimensionTexture2D = 0x4,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE2DARRAY")]
        D3D11SrvDimensionTexture2Darray = 0x5,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE2DMS")]
        D3D11SrvDimensionTexture2Dms = 0x6,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY")]
        D3D11SrvDimensionTexture2Dmsarray = 0x7,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURE3D")]
        D3D11SrvDimensionTexture3D = 0x8,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURECUBE")]
        D3D11SrvDimensionTexturecube = 0x9,
        [NativeName("Name", "D3D11_SRV_DIMENSION_TEXTURECUBEARRAY")]
        D3D11SrvDimensionTexturecubearray = 0xA,
        [NativeName("Name", "D3D11_SRV_DIMENSION_BUFFEREX")]
        D3D11SrvDimensionBufferex = 0xB,
    }
}
