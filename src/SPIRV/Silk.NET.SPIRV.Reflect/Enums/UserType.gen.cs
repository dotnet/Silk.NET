// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectUserType")]
    public enum UserType : int
    {
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_INVALID")]
        Invalid = 0x0,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_CBUFFER")]
        Cbuffer = 0x1,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TBUFFER")]
        Tbuffer = 0x2,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_APPEND_STRUCTURED_BUFFER")]
        AppendStructuredBuffer = 0x3,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_BUFFER")]
        Buffer = 0x4,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_BYTE_ADDRESS_BUFFER")]
        ByteAddressBuffer = 0x5,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_CONSTANT_BUFFER")]
        ConstantBuffer = 0x6,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_CONSUME_STRUCTURED_BUFFER")]
        ConsumeStructuredBuffer = 0x7,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_INPUT_PATCH")]
        InputPatch = 0x8,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_OUTPUT_PATCH")]
        OutputPatch = 0x9,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_BUFFER")]
        RasterizerOrderedBuffer = 0xA,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_BYTE_ADDRESS_BUFFER")]
        RasterizerOrderedByteAddressBuffer = 0xB,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_STRUCTURED_BUFFER")]
        RasterizerOrderedStructuredBuffer = 0xC,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_TEXTURE_1D")]
        RasterizerOrderedTexture1D = 0xD,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_TEXTURE_1D_ARRAY")]
        RasterizerOrderedTexture1DArray = 0xE,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_TEXTURE_2D")]
        RasterizerOrderedTexture2D = 0xF,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_TEXTURE_2D_ARRAY")]
        RasterizerOrderedTexture2DArray = 0x10,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RASTERIZER_ORDERED_TEXTURE_3D")]
        RasterizerOrderedTexture3D = 0x11,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RAYTRACING_ACCELERATION_STRUCTURE")]
        RaytracingAccelerationStructure = 0x12,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_BUFFER")]
        RWBuffer = 0x13,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_BYTE_ADDRESS_BUFFER")]
        RWByteAddressBuffer = 0x14,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_STRUCTURED_BUFFER")]
        RWStructuredBuffer = 0x15,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_TEXTURE_1D")]
        RWTexture1D = 0x16,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_TEXTURE_1D_ARRAY")]
        RWTexture1DArray = 0x17,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_TEXTURE_2D")]
        RWTexture2D = 0x18,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_TEXTURE_2D_ARRAY")]
        RWTexture2DArray = 0x19,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_RW_TEXTURE_3D")]
        RWTexture3D = 0x1A,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_STRUCTURED_BUFFER")]
        StructuredBuffer = 0x1B,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_SUBPASS_INPUT")]
        SubpassInput = 0x1C,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_SUBPASS_INPUT_MS")]
        SubpassInputMS = 0x1D,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_1D")]
        Texture1D = 0x1E,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_1D_ARRAY")]
        Texture1DArray = 0x1F,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_2D")]
        Texture2D = 0x20,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x21,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_2DMS")]
        Texture2Dms = 0x22,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_2DMS_ARRAY")]
        Texture2DmsArray = 0x23,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_3D")]
        Texture3D = 0x24,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_BUFFER")]
        TextureBuffer = 0x25,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_CUBE")]
        TextureCube = 0x26,
        [NativeName("Name", "SPV_REFLECT_USER_TYPE_TEXTURE_CUBE_ARRAY")]
        TextureCubeArray = 0x27,
    }
}
