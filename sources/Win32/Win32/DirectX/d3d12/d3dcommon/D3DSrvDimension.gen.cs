// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION"]/*'/>
public enum D3DSrvDimension
{
    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_UNKNOWN"]/*'/>

    DSrvDimensionUnknown = 0,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFER"]/*'/>

    DSrvDimensionBuffer = 1,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1D"]/*'/>

    DSrvDimensionTexture1D = 2,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    DSrvDimensionTexture1Darray = 3,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2D"]/*'/>

    DSrvDimensionTexture2D = 4,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    DSrvDimensionTexture2Darray = 5,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMS"]/*'/>

    DSrvDimensionTexture2Dms = 6,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    DSrvDimensionTexture2Dmsarray = 7,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURE3D"]/*'/>

    DSrvDimensionTexture3D = 8,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBE"]/*'/>

    DSrvDimensionTexturecube = 9,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_TEXTURECUBEARRAY"]/*'/>

    DSrvDimensionTexturecubearray = 10,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D_SRV_DIMENSION_BUFFEREX"]/*'/>

    DSrvDimensionBufferex = 11,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_UNKNOWN"]/*'/>

    D10SrvDimensionUnknown = DSrvDimensionUnknown,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_BUFFER"]/*'/>

    D10SrvDimensionBuffer = DSrvDimensionBuffer,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1D"]/*'/>

    D10SrvDimensionTexture1D = DSrvDimensionTexture1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    D10SrvDimensionTexture1Darray = DSrvDimensionTexture1Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2D"]/*'/>

    D10SrvDimensionTexture2D = DSrvDimensionTexture2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    D10SrvDimensionTexture2Darray = DSrvDimensionTexture2Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMS"]/*'/>

    D10SrvDimensionTexture2Dms = DSrvDimensionTexture2Dms,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    D10SrvDimensionTexture2Dmsarray = DSrvDimensionTexture2Dmsarray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURE3D"]/*'/>

    D10SrvDimensionTexture3D = DSrvDimensionTexture3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_SRV_DIMENSION_TEXTURECUBE"]/*'/>

    D10SrvDimensionTexturecube = DSrvDimensionTexturecube,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_UNKNOWN"]/*'/>

    D10X1SrvDimensionUnknown = DSrvDimensionUnknown,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_BUFFER"]/*'/>

    D10X1SrvDimensionBuffer = DSrvDimensionBuffer,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1D"]/*'/>

    D10X1SrvDimensionTexture1D = DSrvDimensionTexture1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    D10X1SrvDimensionTexture1Darray = DSrvDimensionTexture1Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2D"]/*'/>

    D10X1SrvDimensionTexture2D = DSrvDimensionTexture2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    D10X1SrvDimensionTexture2Darray = DSrvDimensionTexture2Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMS"]/*'/>

    D10X1SrvDimensionTexture2Dms = DSrvDimensionTexture2Dms,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    D10X1SrvDimensionTexture2Dmsarray = DSrvDimensionTexture2Dmsarray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURE3D"]/*'/>

    D10X1SrvDimensionTexture3D = DSrvDimensionTexture3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBE"]/*'/>

    D10X1SrvDimensionTexturecube = DSrvDimensionTexturecube,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D10_1_SRV_DIMENSION_TEXTURECUBEARRAY"]/*'/>

    D10X1SrvDimensionTexturecubearray = DSrvDimensionTexturecubearray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_UNKNOWN"]/*'/>

    D11SrvDimensionUnknown = DSrvDimensionUnknown,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFER"]/*'/>

    D11SrvDimensionBuffer = DSrvDimensionBuffer,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1D"]/*'/>

    D11SrvDimensionTexture1D = DSrvDimensionTexture1D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    D11SrvDimensionTexture1Darray = DSrvDimensionTexture1Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2D"]/*'/>

    D11SrvDimensionTexture2D = DSrvDimensionTexture2D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    D11SrvDimensionTexture2Darray = DSrvDimensionTexture2Darray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMS"]/*'/>

    D11SrvDimensionTexture2Dms = DSrvDimensionTexture2Dms,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    D11SrvDimensionTexture2Dmsarray = DSrvDimensionTexture2Dmsarray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE3D"]/*'/>

    D11SrvDimensionTexture3D = DSrvDimensionTexture3D,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBE"]/*'/>

    D11SrvDimensionTexturecube = DSrvDimensionTexturecube,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURECUBEARRAY"]/*'/>

    D11SrvDimensionTexturecubearray = DSrvDimensionTexturecubearray,

    /// <include file='D3D_SRV_DIMENSION.xml' path='doc/member[@name="D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFEREX"]/*'/>

    D11SrvDimensionBufferex = DSrvDimensionBufferex,
}
