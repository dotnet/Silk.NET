// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_VARIABLE_TYPE")]
    public enum ShaderVariableType
    {
        [NativeName("Name", "D3D_SVT_VOID")]
        SvtVoid = 0x0,
        [NativeName("Name", "D3D_SVT_BOOL")]
        SvtBool = 0x1,
        [NativeName("Name", "D3D_SVT_INT")]
        SvtInt = 0x2,
        [NativeName("Name", "D3D_SVT_FLOAT")]
        SvtFloat = 0x3,
        [NativeName("Name", "D3D_SVT_STRING")]
        SvtString = 0x4,
        [NativeName("Name", "D3D_SVT_TEXTURE")]
        SvtTexture = 0x5,
        [NativeName("Name", "D3D_SVT_TEXTURE1D")]
        SvtTexture1D = 0x6,
        [NativeName("Name", "D3D_SVT_TEXTURE2D")]
        SvtTexture2D = 0x7,
        [NativeName("Name", "D3D_SVT_TEXTURE3D")]
        SvtTexture3D = 0x8,
        [NativeName("Name", "D3D_SVT_TEXTURECUBE")]
        SvtTexturecube = 0x9,
        [NativeName("Name", "D3D_SVT_SAMPLER")]
        SvtSampler = 0xA,
        [NativeName("Name", "D3D_SVT_SAMPLER1D")]
        SvtSampler1D = 0xB,
        [NativeName("Name", "D3D_SVT_SAMPLER2D")]
        SvtSampler2D = 0xC,
        [NativeName("Name", "D3D_SVT_SAMPLER3D")]
        SvtSampler3D = 0xD,
        [NativeName("Name", "D3D_SVT_SAMPLERCUBE")]
        SvtSamplercube = 0xE,
        [NativeName("Name", "D3D_SVT_PIXELSHADER")]
        SvtPixelshader = 0xF,
        [NativeName("Name", "D3D_SVT_VERTEXSHADER")]
        SvtVertexshader = 0x10,
        [NativeName("Name", "D3D_SVT_PIXELFRAGMENT")]
        SvtPixelfragment = 0x11,
        [NativeName("Name", "D3D_SVT_VERTEXFRAGMENT")]
        SvtVertexfragment = 0x12,
        [NativeName("Name", "D3D_SVT_UINT")]
        SvtUint = 0x13,
        [NativeName("Name", "D3D_SVT_UINT8")]
        SvtUint8 = 0x14,
        [NativeName("Name", "D3D_SVT_GEOMETRYSHADER")]
        SvtGeometryshader = 0x15,
        [NativeName("Name", "D3D_SVT_RASTERIZER")]
        SvtRasterizer = 0x16,
        [NativeName("Name", "D3D_SVT_DEPTHSTENCIL")]
        SvtDepthstencil = 0x17,
        [NativeName("Name", "D3D_SVT_BLEND")]
        SvtBlend = 0x18,
        [NativeName("Name", "D3D_SVT_BUFFER")]
        SvtBuffer = 0x19,
        [NativeName("Name", "D3D_SVT_CBUFFER")]
        SvtCbuffer = 0x1A,
        [NativeName("Name", "D3D_SVT_TBUFFER")]
        SvtTbuffer = 0x1B,
        [NativeName("Name", "D3D_SVT_TEXTURE1DARRAY")]
        SvtTexture1Darray = 0x1C,
        [NativeName("Name", "D3D_SVT_TEXTURE2DARRAY")]
        SvtTexture2Darray = 0x1D,
        [NativeName("Name", "D3D_SVT_RENDERTARGETVIEW")]
        SvtRendertargetview = 0x1E,
        [NativeName("Name", "D3D_SVT_DEPTHSTENCILVIEW")]
        SvtDepthstencilview = 0x1F,
        [NativeName("Name", "D3D_SVT_TEXTURE2DMS")]
        SvtTexture2Dms = 0x20,
        [NativeName("Name", "D3D_SVT_TEXTURE2DMSARRAY")]
        SvtTexture2Dmsarray = 0x21,
        [NativeName("Name", "D3D_SVT_TEXTURECUBEARRAY")]
        SvtTexturecubearray = 0x22,
        [NativeName("Name", "D3D_SVT_HULLSHADER")]
        SvtHullshader = 0x23,
        [NativeName("Name", "D3D_SVT_DOMAINSHADER")]
        SvtDomainshader = 0x24,
        [NativeName("Name", "D3D_SVT_INTERFACE_POINTER")]
        SvtInterfacePointer = 0x25,
        [NativeName("Name", "D3D_SVT_COMPUTESHADER")]
        SvtComputeshader = 0x26,
        [NativeName("Name", "D3D_SVT_DOUBLE")]
        SvtDouble = 0x27,
        [NativeName("Name", "D3D_SVT_RWTEXTURE1D")]
        SvtRwtexture1D = 0x28,
        [NativeName("Name", "D3D_SVT_RWTEXTURE1DARRAY")]
        SvtRwtexture1Darray = 0x29,
        [NativeName("Name", "D3D_SVT_RWTEXTURE2D")]
        SvtRwtexture2D = 0x2A,
        [NativeName("Name", "D3D_SVT_RWTEXTURE2DARRAY")]
        SvtRwtexture2Darray = 0x2B,
        [NativeName("Name", "D3D_SVT_RWTEXTURE3D")]
        SvtRwtexture3D = 0x2C,
        [NativeName("Name", "D3D_SVT_RWBUFFER")]
        SvtRwbuffer = 0x2D,
        [NativeName("Name", "D3D_SVT_BYTEADDRESS_BUFFER")]
        SvtByteaddressBuffer = 0x2E,
        [NativeName("Name", "D3D_SVT_RWBYTEADDRESS_BUFFER")]
        SvtRwbyteaddressBuffer = 0x2F,
        [NativeName("Name", "D3D_SVT_STRUCTURED_BUFFER")]
        SvtStructuredBuffer = 0x30,
        [NativeName("Name", "D3D_SVT_RWSTRUCTURED_BUFFER")]
        SvtRwstructuredBuffer = 0x31,
        [NativeName("Name", "D3D_SVT_APPEND_STRUCTURED_BUFFER")]
        SvtAppendStructuredBuffer = 0x32,
        [NativeName("Name", "D3D_SVT_CONSUME_STRUCTURED_BUFFER")]
        SvtConsumeStructuredBuffer = 0x33,
        [NativeName("Name", "D3D_SVT_MIN8FLOAT")]
        SvtMin8float = 0x34,
        [NativeName("Name", "D3D_SVT_MIN10FLOAT")]
        SvtMin10float = 0x35,
        [NativeName("Name", "D3D_SVT_MIN16FLOAT")]
        SvtMin16float = 0x36,
        [NativeName("Name", "D3D_SVT_MIN12INT")]
        SvtMin12int = 0x37,
        [NativeName("Name", "D3D_SVT_MIN16INT")]
        SvtMin16int = 0x38,
        [NativeName("Name", "D3D_SVT_MIN16UINT")]
        SvtMin16Uint = 0x39,
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
        SvtForceDword = 0x7FFFFFFF,
    }
}
