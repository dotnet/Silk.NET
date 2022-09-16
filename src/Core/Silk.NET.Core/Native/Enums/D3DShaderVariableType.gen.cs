// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_VARIABLE_TYPE")]
    public enum D3DShaderVariableType : int
    {
        [NativeName("Name", "D3D_SVT_VOID")]
        D3DSvtVoid = 0x0,
        [NativeName("Name", "D3D_SVT_BOOL")]
        D3DSvtBool = 0x1,
        [NativeName("Name", "D3D_SVT_INT")]
        D3DSvtInt = 0x2,
        [NativeName("Name", "D3D_SVT_FLOAT")]
        D3DSvtFloat = 0x3,
        [NativeName("Name", "D3D_SVT_STRING")]
        D3DSvtString = 0x4,
        [NativeName("Name", "D3D_SVT_TEXTURE")]
        D3DSvtTexture = 0x5,
        [NativeName("Name", "D3D_SVT_TEXTURE1D")]
        D3DSvtTexture1D = 0x6,
        [NativeName("Name", "D3D_SVT_TEXTURE2D")]
        D3DSvtTexture2D = 0x7,
        [NativeName("Name", "D3D_SVT_TEXTURE3D")]
        D3DSvtTexture3D = 0x8,
        [NativeName("Name", "D3D_SVT_TEXTURECUBE")]
        D3DSvtTexturecube = 0x9,
        [NativeName("Name", "D3D_SVT_SAMPLER")]
        D3DSvtSampler = 0xA,
        [NativeName("Name", "D3D_SVT_SAMPLER1D")]
        D3DSvtSampler1D = 0xB,
        [NativeName("Name", "D3D_SVT_SAMPLER2D")]
        D3DSvtSampler2D = 0xC,
        [NativeName("Name", "D3D_SVT_SAMPLER3D")]
        D3DSvtSampler3D = 0xD,
        [NativeName("Name", "D3D_SVT_SAMPLERCUBE")]
        D3DSvtSamplercube = 0xE,
        [NativeName("Name", "D3D_SVT_PIXELSHADER")]
        D3DSvtPixelshader = 0xF,
        [NativeName("Name", "D3D_SVT_VERTEXSHADER")]
        D3DSvtVertexshader = 0x10,
        [NativeName("Name", "D3D_SVT_PIXELFRAGMENT")]
        D3DSvtPixelfragment = 0x11,
        [NativeName("Name", "D3D_SVT_VERTEXFRAGMENT")]
        D3DSvtVertexfragment = 0x12,
        [NativeName("Name", "D3D_SVT_UINT")]
        D3DSvtUint = 0x13,
        [NativeName("Name", "D3D_SVT_UINT8")]
        D3DSvtUint8 = 0x14,
        [NativeName("Name", "D3D_SVT_GEOMETRYSHADER")]
        D3DSvtGeometryshader = 0x15,
        [NativeName("Name", "D3D_SVT_RASTERIZER")]
        D3DSvtRasterizer = 0x16,
        [NativeName("Name", "D3D_SVT_DEPTHSTENCIL")]
        D3DSvtDepthstencil = 0x17,
        [NativeName("Name", "D3D_SVT_BLEND")]
        D3DSvtBlend = 0x18,
        [NativeName("Name", "D3D_SVT_BUFFER")]
        D3DSvtBuffer = 0x19,
        [NativeName("Name", "D3D_SVT_CBUFFER")]
        D3DSvtCbuffer = 0x1A,
        [NativeName("Name", "D3D_SVT_TBUFFER")]
        D3DSvtTbuffer = 0x1B,
        [NativeName("Name", "D3D_SVT_TEXTURE1DARRAY")]
        D3DSvtTexture1Darray = 0x1C,
        [NativeName("Name", "D3D_SVT_TEXTURE2DARRAY")]
        D3DSvtTexture2Darray = 0x1D,
        [NativeName("Name", "D3D_SVT_RENDERTARGETVIEW")]
        D3DSvtRendertargetview = 0x1E,
        [NativeName("Name", "D3D_SVT_DEPTHSTENCILVIEW")]
        D3DSvtDepthstencilview = 0x1F,
        [NativeName("Name", "D3D_SVT_TEXTURE2DMS")]
        D3DSvtTexture2Dms = 0x20,
        [NativeName("Name", "D3D_SVT_TEXTURE2DMSARRAY")]
        D3DSvtTexture2Dmsarray = 0x21,
        [NativeName("Name", "D3D_SVT_TEXTURECUBEARRAY")]
        D3DSvtTexturecubearray = 0x22,
        [NativeName("Name", "D3D_SVT_HULLSHADER")]
        D3DSvtHullshader = 0x23,
        [NativeName("Name", "D3D_SVT_DOMAINSHADER")]
        D3DSvtDomainshader = 0x24,
        [NativeName("Name", "D3D_SVT_INTERFACE_POINTER")]
        D3DSvtInterfacePointer = 0x25,
        [NativeName("Name", "D3D_SVT_COMPUTESHADER")]
        D3DSvtComputeshader = 0x26,
        [NativeName("Name", "D3D_SVT_DOUBLE")]
        D3DSvtDouble = 0x27,
        [NativeName("Name", "D3D_SVT_RWTEXTURE1D")]
        D3DSvtRwtexture1D = 0x28,
        [NativeName("Name", "D3D_SVT_RWTEXTURE1DARRAY")]
        D3DSvtRwtexture1Darray = 0x29,
        [NativeName("Name", "D3D_SVT_RWTEXTURE2D")]
        D3DSvtRwtexture2D = 0x2A,
        [NativeName("Name", "D3D_SVT_RWTEXTURE2DARRAY")]
        D3DSvtRwtexture2Darray = 0x2B,
        [NativeName("Name", "D3D_SVT_RWTEXTURE3D")]
        D3DSvtRwtexture3D = 0x2C,
        [NativeName("Name", "D3D_SVT_RWBUFFER")]
        D3DSvtRwbuffer = 0x2D,
        [NativeName("Name", "D3D_SVT_BYTEADDRESS_BUFFER")]
        D3DSvtByteaddressBuffer = 0x2E,
        [NativeName("Name", "D3D_SVT_RWBYTEADDRESS_BUFFER")]
        D3DSvtRwbyteaddressBuffer = 0x2F,
        [NativeName("Name", "D3D_SVT_STRUCTURED_BUFFER")]
        D3DSvtStructuredBuffer = 0x30,
        [NativeName("Name", "D3D_SVT_RWSTRUCTURED_BUFFER")]
        D3DSvtRwstructuredBuffer = 0x31,
        [NativeName("Name", "D3D_SVT_APPEND_STRUCTURED_BUFFER")]
        D3DSvtAppendStructuredBuffer = 0x32,
        [NativeName("Name", "D3D_SVT_CONSUME_STRUCTURED_BUFFER")]
        D3DSvtConsumeStructuredBuffer = 0x33,
        [NativeName("Name", "D3D_SVT_MIN8FLOAT")]
        D3DSvtMin8float = 0x34,
        [NativeName("Name", "D3D_SVT_MIN10FLOAT")]
        D3DSvtMin10float = 0x35,
        [NativeName("Name", "D3D_SVT_MIN16FLOAT")]
        D3DSvtMin16float = 0x36,
        [NativeName("Name", "D3D_SVT_MIN12INT")]
        D3DSvtMin12int = 0x37,
        [NativeName("Name", "D3D_SVT_MIN16INT")]
        D3DSvtMin16int = 0x38,
        [NativeName("Name", "D3D_SVT_MIN16UINT")]
        D3DSvtMin16Uint = 0x39,
        [NativeName("Name", "D3D_SVT_INT16")]
        D3DSvtInt16 = 0x3A,
        [NativeName("Name", "D3D_SVT_UINT16")]
        D3DSvtUint16 = 0x3B,
        [NativeName("Name", "D3D_SVT_FLOAT16")]
        D3DSvtFloat16 = 0x3C,
        [NativeName("Name", "D3D_SVT_INT64")]
        D3DSvtInt64 = 0x3D,
        [NativeName("Name", "D3D_SVT_UINT64")]
        D3DSvtUint64 = 0x3E,
        [NativeName("Name", "D3D10_SVT_VOID")]
        D3D10SvtVoid = 0x0,
        [NativeName("Name", "D3D10_SVT_BOOL")]
        D3D10SvtBool = 0x1,
        [NativeName("Name", "D3D10_SVT_INT")]
        D3D10SvtInt = 0x2,
        [NativeName("Name", "D3D10_SVT_FLOAT")]
        D3D10SvtFloat = 0x3,
        [NativeName("Name", "D3D10_SVT_STRING")]
        D3D10SvtString = 0x4,
        [NativeName("Name", "D3D10_SVT_TEXTURE")]
        D3D10SvtTexture = 0x5,
        [NativeName("Name", "D3D10_SVT_TEXTURE1D")]
        D3D10SvtTexture1D = 0x6,
        [NativeName("Name", "D3D10_SVT_TEXTURE2D")]
        D3D10SvtTexture2D = 0x7,
        [NativeName("Name", "D3D10_SVT_TEXTURE3D")]
        D3D10SvtTexture3D = 0x8,
        [NativeName("Name", "D3D10_SVT_TEXTURECUBE")]
        D3D10SvtTexturecube = 0x9,
        [NativeName("Name", "D3D10_SVT_SAMPLER")]
        D3D10SvtSampler = 0xA,
        [NativeName("Name", "D3D10_SVT_SAMPLER1D")]
        D3D10SvtSampler1D = 0xB,
        [NativeName("Name", "D3D10_SVT_SAMPLER2D")]
        D3D10SvtSampler2D = 0xC,
        [NativeName("Name", "D3D10_SVT_SAMPLER3D")]
        D3D10SvtSampler3D = 0xD,
        [NativeName("Name", "D3D10_SVT_SAMPLERCUBE")]
        D3D10SvtSamplercube = 0xE,
        [NativeName("Name", "D3D10_SVT_PIXELSHADER")]
        D3D10SvtPixelshader = 0xF,
        [NativeName("Name", "D3D10_SVT_VERTEXSHADER")]
        D3D10SvtVertexshader = 0x10,
        [NativeName("Name", "D3D10_SVT_PIXELFRAGMENT")]
        D3D10SvtPixelfragment = 0x11,
        [NativeName("Name", "D3D10_SVT_VERTEXFRAGMENT")]
        D3D10SvtVertexfragment = 0x12,
        [NativeName("Name", "D3D10_SVT_UINT")]
        D3D10SvtUint = 0x13,
        [NativeName("Name", "D3D10_SVT_UINT8")]
        D3D10SvtUint8 = 0x14,
        [NativeName("Name", "D3D10_SVT_GEOMETRYSHADER")]
        D3D10SvtGeometryshader = 0x15,
        [NativeName("Name", "D3D10_SVT_RASTERIZER")]
        D3D10SvtRasterizer = 0x16,
        [NativeName("Name", "D3D10_SVT_DEPTHSTENCIL")]
        D3D10SvtDepthstencil = 0x17,
        [NativeName("Name", "D3D10_SVT_BLEND")]
        D3D10SvtBlend = 0x18,
        [NativeName("Name", "D3D10_SVT_BUFFER")]
        D3D10SvtBuffer = 0x19,
        [NativeName("Name", "D3D10_SVT_CBUFFER")]
        D3D10SvtCbuffer = 0x1A,
        [NativeName("Name", "D3D10_SVT_TBUFFER")]
        D3D10SvtTbuffer = 0x1B,
        [NativeName("Name", "D3D10_SVT_TEXTURE1DARRAY")]
        D3D10SvtTexture1Darray = 0x1C,
        [NativeName("Name", "D3D10_SVT_TEXTURE2DARRAY")]
        D3D10SvtTexture2Darray = 0x1D,
        [NativeName("Name", "D3D10_SVT_RENDERTARGETVIEW")]
        D3D10SvtRendertargetview = 0x1E,
        [NativeName("Name", "D3D10_SVT_DEPTHSTENCILVIEW")]
        D3D10SvtDepthstencilview = 0x1F,
        [NativeName("Name", "D3D10_SVT_TEXTURE2DMS")]
        D3D10SvtTexture2Dms = 0x20,
        [NativeName("Name", "D3D10_SVT_TEXTURE2DMSARRAY")]
        D3D10SvtTexture2Dmsarray = 0x21,
        [NativeName("Name", "D3D10_SVT_TEXTURECUBEARRAY")]
        D3D10SvtTexturecubearray = 0x22,
        [NativeName("Name", "D3D11_SVT_HULLSHADER")]
        D3D11SvtHullshader = 0x23,
        [NativeName("Name", "D3D11_SVT_DOMAINSHADER")]
        D3D11SvtDomainshader = 0x24,
        [NativeName("Name", "D3D11_SVT_INTERFACE_POINTER")]
        D3D11SvtInterfacePointer = 0x25,
        [NativeName("Name", "D3D11_SVT_COMPUTESHADER")]
        D3D11SvtComputeshader = 0x26,
        [NativeName("Name", "D3D11_SVT_DOUBLE")]
        D3D11SvtDouble = 0x27,
        [NativeName("Name", "D3D11_SVT_RWTEXTURE1D")]
        D3D11SvtRwtexture1D = 0x28,
        [NativeName("Name", "D3D11_SVT_RWTEXTURE1DARRAY")]
        D3D11SvtRwtexture1Darray = 0x29,
        [NativeName("Name", "D3D11_SVT_RWTEXTURE2D")]
        D3D11SvtRwtexture2D = 0x2A,
        [NativeName("Name", "D3D11_SVT_RWTEXTURE2DARRAY")]
        D3D11SvtRwtexture2Darray = 0x2B,
        [NativeName("Name", "D3D11_SVT_RWTEXTURE3D")]
        D3D11SvtRwtexture3D = 0x2C,
        [NativeName("Name", "D3D11_SVT_RWBUFFER")]
        D3D11SvtRwbuffer = 0x2D,
        [NativeName("Name", "D3D11_SVT_BYTEADDRESS_BUFFER")]
        D3D11SvtByteaddressBuffer = 0x2E,
        [NativeName("Name", "D3D11_SVT_RWBYTEADDRESS_BUFFER")]
        D3D11SvtRwbyteaddressBuffer = 0x2F,
        [NativeName("Name", "D3D11_SVT_STRUCTURED_BUFFER")]
        D3D11SvtStructuredBuffer = 0x30,
        [NativeName("Name", "D3D11_SVT_RWSTRUCTURED_BUFFER")]
        D3D11SvtRwstructuredBuffer = 0x31,
        [NativeName("Name", "D3D11_SVT_APPEND_STRUCTURED_BUFFER")]
        D3D11SvtAppendStructuredBuffer = 0x32,
        [NativeName("Name", "D3D11_SVT_CONSUME_STRUCTURED_BUFFER")]
        D3D11SvtConsumeStructuredBuffer = 0x33,
        [NativeName("Name", "D3D_SVT_FORCE_DWORD")]
        D3DSvtForceDword = 0x7FFFFFFF,
    }
}
