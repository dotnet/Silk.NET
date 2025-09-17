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

/// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE"]/*'/>
public enum D3DShaderVariableType
{
    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VOID"]/*'/>

    DSvtVoid = 0,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BOOL"]/*'/>

    DSvtBool = 1,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT"]/*'/>

    DSvtInt = 2,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FLOAT"]/*'/>

    DSvtFloat = 3,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_STRING"]/*'/>

    DSvtString = 4,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE"]/*'/>

    DSvtTexture = 5,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE1D"]/*'/>

    DSvtTexture1D = 6,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2D"]/*'/>

    DSvtTexture2D = 7,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE3D"]/*'/>

    DSvtTexture3D = 8,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURECUBE"]/*'/>

    DSvtTexturecube = 9,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER"]/*'/>

    DSvtSampler = 10,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER1D"]/*'/>

    DSvtSampler1D = 11,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER2D"]/*'/>

    DSvtSampler2D = 12,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER3D"]/*'/>

    DSvtSampler3D = 13,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLERCUBE"]/*'/>

    DSvtSamplercube = 14,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_PIXELSHADER"]/*'/>

    DSvtPixelshader = 15,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VERTEXSHADER"]/*'/>

    DSvtVertexshader = 16,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_PIXELFRAGMENT"]/*'/>

    DSvtPixelfragment = 17,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VERTEXFRAGMENT"]/*'/>

    DSvtVertexfragment = 18,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT"]/*'/>

    DSvtUint = 19,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT8"]/*'/>

    DSvtUint8 = 20,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_GEOMETRYSHADER"]/*'/>

    DSvtGeometryshader = 21,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RASTERIZER"]/*'/>

    DSvtRasterizer = 22,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DEPTHSTENCIL"]/*'/>

    DSvtDepthstencil = 23,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BLEND"]/*'/>

    DSvtBlend = 24,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BUFFER"]/*'/>

    DSvtBuffer = 25,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_CBUFFER"]/*'/>

    DSvtCbuffer = 26,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TBUFFER"]/*'/>

    DSvtTbuffer = 27,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE1DARRAY"]/*'/>

    DSvtTexture1Darray = 28,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DARRAY"]/*'/>

    DSvtTexture2Darray = 29,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RENDERTARGETVIEW"]/*'/>

    DSvtRendertargetview = 30,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DEPTHSTENCILVIEW"]/*'/>

    DSvtDepthstencilview = 31,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DMS"]/*'/>

    DSvtTexture2Dms = 32,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DMSARRAY"]/*'/>

    DSvtTexture2Dmsarray = 33,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURECUBEARRAY"]/*'/>

    DSvtTexturecubearray = 34,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_HULLSHADER"]/*'/>

    DSvtHullshader = 35,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DOMAINSHADER"]/*'/>

    DSvtDomainshader = 36,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INTERFACE_POINTER"]/*'/>

    DSvtInterfacePointer = 37,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_COMPUTESHADER"]/*'/>

    DSvtComputeshader = 38,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DOUBLE"]/*'/>

    DSvtDouble = 39,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE1D"]/*'/>

    DSvtRwtexture1D = 40,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE1DARRAY"]/*'/>

    DSvtRwtexture1Darray = 41,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE2D"]/*'/>

    DSvtRwtexture2D = 42,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE2DARRAY"]/*'/>

    DSvtRwtexture2Darray = 43,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE3D"]/*'/>

    DSvtRwtexture3D = 44,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWBUFFER"]/*'/>

    DSvtRwbuffer = 45,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BYTEADDRESS_BUFFER"]/*'/>

    DSvtByteaddressBuffer = 46,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWBYTEADDRESS_BUFFER"]/*'/>

    DSvtRwbyteaddressBuffer = 47,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_STRUCTURED_BUFFER"]/*'/>

    DSvtStructuredBuffer = 48,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWSTRUCTURED_BUFFER"]/*'/>

    DSvtRwstructuredBuffer = 49,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_APPEND_STRUCTURED_BUFFER"]/*'/>

    DSvtAppendStructuredBuffer = 50,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_CONSUME_STRUCTURED_BUFFER"]/*'/>

    DSvtConsumeStructuredBuffer = 51,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN8FLOAT"]/*'/>

    DSvtMin8Float = 52,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN10FLOAT"]/*'/>

    DSvtMin10Float = 53,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16FLOAT"]/*'/>

    DSvtMin16Float = 54,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN12INT"]/*'/>

    DSvtMin12Int = 55,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16INT"]/*'/>

    DSvtMin16Int = 56,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16UINT"]/*'/>

    DSvtMin16Uint = 57,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT16"]/*'/>

    DSvtInt16 = 58,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT16"]/*'/>

    DSvtUint16 = 59,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FLOAT16"]/*'/>

    DSvtFloat16 = 60,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT64"]/*'/>

    DSvtInt64 = 61,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT64"]/*'/>

    DSvtUint64 = 62,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VOID"]/*'/>

    D10SvtVoid = DSvtVoid,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BOOL"]/*'/>

    D10SvtBool = DSvtBool,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_INT"]/*'/>

    D10SvtInt = DSvtInt,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_FLOAT"]/*'/>

    D10SvtFloat = DSvtFloat,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_STRING"]/*'/>

    D10SvtString = DSvtString,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE"]/*'/>

    D10SvtTexture = DSvtTexture,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE1D"]/*'/>

    D10SvtTexture1D = DSvtTexture1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2D"]/*'/>

    D10SvtTexture2D = DSvtTexture2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE3D"]/*'/>

    D10SvtTexture3D = DSvtTexture3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURECUBE"]/*'/>

    D10SvtTexturecube = DSvtTexturecube,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER"]/*'/>

    D10SvtSampler = DSvtSampler,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER1D"]/*'/>

    D10SvtSampler1D = DSvtSampler1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER2D"]/*'/>

    D10SvtSampler2D = DSvtSampler2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER3D"]/*'/>

    D10SvtSampler3D = DSvtSampler3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLERCUBE"]/*'/>

    D10SvtSamplercube = DSvtSamplercube,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_PIXELSHADER"]/*'/>

    D10SvtPixelshader = DSvtPixelshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VERTEXSHADER"]/*'/>

    D10SvtVertexshader = DSvtVertexshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_PIXELFRAGMENT"]/*'/>

    D10SvtPixelfragment = DSvtPixelfragment,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VERTEXFRAGMENT"]/*'/>

    D10SvtVertexfragment = DSvtVertexfragment,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_UINT"]/*'/>

    D10SvtUint = DSvtUint,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_UINT8"]/*'/>

    D10SvtUint8 = DSvtUint8,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_GEOMETRYSHADER"]/*'/>

    D10SvtGeometryshader = DSvtGeometryshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_RASTERIZER"]/*'/>

    D10SvtRasterizer = DSvtRasterizer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_DEPTHSTENCIL"]/*'/>

    D10SvtDepthstencil = DSvtDepthstencil,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BLEND"]/*'/>

    D10SvtBlend = DSvtBlend,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BUFFER"]/*'/>

    D10SvtBuffer = DSvtBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_CBUFFER"]/*'/>

    D10SvtCbuffer = DSvtCbuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TBUFFER"]/*'/>

    D10SvtTbuffer = DSvtTbuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE1DARRAY"]/*'/>

    D10SvtTexture1Darray = DSvtTexture1Darray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DARRAY"]/*'/>

    D10SvtTexture2Darray = DSvtTexture2Darray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_RENDERTARGETVIEW"]/*'/>

    D10SvtRendertargetview = DSvtRendertargetview,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_DEPTHSTENCILVIEW"]/*'/>

    D10SvtDepthstencilview = DSvtDepthstencilview,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DMS"]/*'/>

    D10SvtTexture2Dms = DSvtTexture2Dms,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DMSARRAY"]/*'/>

    D10SvtTexture2Dmsarray = DSvtTexture2Dmsarray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURECUBEARRAY"]/*'/>

    D10SvtTexturecubearray = DSvtTexturecubearray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_HULLSHADER"]/*'/>

    D11SvtHullshader = DSvtHullshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_DOMAINSHADER"]/*'/>

    D11SvtDomainshader = DSvtDomainshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_INTERFACE_POINTER"]/*'/>

    D11SvtInterfacePointer = DSvtInterfacePointer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_COMPUTESHADER"]/*'/>

    D11SvtComputeshader = DSvtComputeshader,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_DOUBLE"]/*'/>

    D11SvtDouble = DSvtDouble,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE1D"]/*'/>

    D11SvtRwtexture1D = DSvtRwtexture1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE1DARRAY"]/*'/>

    D11SvtRwtexture1Darray = DSvtRwtexture1Darray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE2D"]/*'/>

    D11SvtRwtexture2D = DSvtRwtexture2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE2DARRAY"]/*'/>

    D11SvtRwtexture2Darray = DSvtRwtexture2Darray,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE3D"]/*'/>

    D11SvtRwtexture3D = DSvtRwtexture3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWBUFFER"]/*'/>

    D11SvtRwbuffer = DSvtRwbuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_BYTEADDRESS_BUFFER"]/*'/>

    D11SvtByteaddressBuffer = DSvtByteaddressBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWBYTEADDRESS_BUFFER"]/*'/>

    D11SvtRwbyteaddressBuffer = DSvtRwbyteaddressBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_STRUCTURED_BUFFER"]/*'/>

    D11SvtStructuredBuffer = DSvtStructuredBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWSTRUCTURED_BUFFER"]/*'/>

    D11SvtRwstructuredBuffer = DSvtRwstructuredBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_APPEND_STRUCTURED_BUFFER"]/*'/>

    D11SvtAppendStructuredBuffer = DSvtAppendStructuredBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_CONSUME_STRUCTURED_BUFFER"]/*'/>

    D11SvtConsumeStructuredBuffer = DSvtConsumeStructuredBuffer,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FORCE_DWORD"]/*'/>

    DSvtForceDword = 0x7fffffff,
}
