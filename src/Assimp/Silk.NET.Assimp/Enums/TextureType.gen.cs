// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureType")]
    public enum TextureType : int
    {
        [NativeName("Name", "aiTextureType_NONE")]
        TextureTypeNone = 0x0,
        [NativeName("Name", "aiTextureType_DIFFUSE")]
        TextureTypeDiffuse = 0x1,
        [NativeName("Name", "aiTextureType_SPECULAR")]
        TextureTypeSpecular = 0x2,
        [NativeName("Name", "aiTextureType_AMBIENT")]
        TextureTypeAmbient = 0x3,
        [NativeName("Name", "aiTextureType_EMISSIVE")]
        TextureTypeEmissive = 0x4,
        [NativeName("Name", "aiTextureType_HEIGHT")]
        TextureTypeHeight = 0x5,
        [NativeName("Name", "aiTextureType_NORMALS")]
        TextureTypeNormals = 0x6,
        [NativeName("Name", "aiTextureType_SHININESS")]
        TextureTypeShininess = 0x7,
        [NativeName("Name", "aiTextureType_OPACITY")]
        TextureTypeOpacity = 0x8,
        [NativeName("Name", "aiTextureType_DISPLACEMENT")]
        TextureTypeDisplacement = 0x9,
        [NativeName("Name", "aiTextureType_LIGHTMAP")]
        TextureTypeLightmap = 0xA,
        [NativeName("Name", "aiTextureType_REFLECTION")]
        TextureTypeReflection = 0xB,
        [NativeName("Name", "aiTextureType_BASE_COLOR")]
        TextureTypeBaseColor = 0xC,
        [NativeName("Name", "aiTextureType_NORMAL_CAMERA")]
        TextureTypeNormalCamera = 0xD,
        [NativeName("Name", "aiTextureType_EMISSION_COLOR")]
        TextureTypeEmissionColor = 0xE,
        [NativeName("Name", "aiTextureType_METALNESS")]
        TextureTypeMetalness = 0xF,
        [NativeName("Name", "aiTextureType_DIFFUSE_ROUGHNESS")]
        TextureTypeDiffuseRoughness = 0x10,
        [NativeName("Name", "aiTextureType_AMBIENT_OCCLUSION")]
        TextureTypeAmbientOcclusion = 0x11,
        [NativeName("Name", "aiTextureType_SHEEN")]
        TextureTypeSheen = 0x13,
        [NativeName("Name", "aiTextureType_CLEARCOAT")]
        TextureTypeClearcoat = 0x14,
        [NativeName("Name", "aiTextureType_TRANSMISSION")]
        TextureTypeTransmission = 0x15,
        [NativeName("Name", "aiTextureType_UNKNOWN")]
        TextureTypeUnknown = 0x12,
    }
}
