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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "aiTextureType_NONE")]
        TextureTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Diffuse\"")]
        [NativeName("Name", "aiTextureType_DIFFUSE")]
        TextureTypeDiffuse = 0x1,
        [Obsolete("Deprecated in favour of \"Specular\"")]
        [NativeName("Name", "aiTextureType_SPECULAR")]
        TextureTypeSpecular = 0x2,
        [Obsolete("Deprecated in favour of \"Ambient\"")]
        [NativeName("Name", "aiTextureType_AMBIENT")]
        TextureTypeAmbient = 0x3,
        [Obsolete("Deprecated in favour of \"Emissive\"")]
        [NativeName("Name", "aiTextureType_EMISSIVE")]
        TextureTypeEmissive = 0x4,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "aiTextureType_HEIGHT")]
        TextureTypeHeight = 0x5,
        [Obsolete("Deprecated in favour of \"Normals\"")]
        [NativeName("Name", "aiTextureType_NORMALS")]
        TextureTypeNormals = 0x6,
        [Obsolete("Deprecated in favour of \"Shininess\"")]
        [NativeName("Name", "aiTextureType_SHININESS")]
        TextureTypeShininess = 0x7,
        [Obsolete("Deprecated in favour of \"Opacity\"")]
        [NativeName("Name", "aiTextureType_OPACITY")]
        TextureTypeOpacity = 0x8,
        [Obsolete("Deprecated in favour of \"Displacement\"")]
        [NativeName("Name", "aiTextureType_DISPLACEMENT")]
        TextureTypeDisplacement = 0x9,
        [Obsolete("Deprecated in favour of \"Lightmap\"")]
        [NativeName("Name", "aiTextureType_LIGHTMAP")]
        TextureTypeLightmap = 0xA,
        [Obsolete("Deprecated in favour of \"Reflection\"")]
        [NativeName("Name", "aiTextureType_REFLECTION")]
        TextureTypeReflection = 0xB,
        [Obsolete("Deprecated in favour of \"BaseColor\"")]
        [NativeName("Name", "aiTextureType_BASE_COLOR")]
        TextureTypeBaseColor = 0xC,
        [Obsolete("Deprecated in favour of \"NormalCamera\"")]
        [NativeName("Name", "aiTextureType_NORMAL_CAMERA")]
        TextureTypeNormalCamera = 0xD,
        [Obsolete("Deprecated in favour of \"EmissionColor\"")]
        [NativeName("Name", "aiTextureType_EMISSION_COLOR")]
        TextureTypeEmissionColor = 0xE,
        [Obsolete("Deprecated in favour of \"Metalness\"")]
        [NativeName("Name", "aiTextureType_METALNESS")]
        TextureTypeMetalness = 0xF,
        [Obsolete("Deprecated in favour of \"DiffuseRoughness\"")]
        [NativeName("Name", "aiTextureType_DIFFUSE_ROUGHNESS")]
        TextureTypeDiffuseRoughness = 0x10,
        [Obsolete("Deprecated in favour of \"AmbientOcclusion\"")]
        [NativeName("Name", "aiTextureType_AMBIENT_OCCLUSION")]
        TextureTypeAmbientOcclusion = 0x11,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "aiTextureType_UNKNOWN")]
        TextureTypeUnknown = 0x12,
        [Obsolete("Deprecated in favour of \"Sheen\"")]
        [NativeName("Name", "aiTextureType_SHEEN")]
        TextureTypeSheen = 0x13,
        [Obsolete("Deprecated in favour of \"Clearcoat\"")]
        [NativeName("Name", "aiTextureType_CLEARCOAT")]
        TextureTypeClearcoat = 0x14,
        [Obsolete("Deprecated in favour of \"Transmission\"")]
        [NativeName("Name", "aiTextureType_TRANSMISSION")]
        TextureTypeTransmission = 0x15,
        [Obsolete("Deprecated in favour of \"MayaBase\"")]
        [NativeName("Name", "aiTextureType_MAYA_BASE")]
        TextureTypeMayaBase = 0x16,
        [Obsolete("Deprecated in favour of \"MayaSpecular\"")]
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR")]
        TextureTypeMayaSpecular = 0x17,
        [Obsolete("Deprecated in favour of \"MayaSpecularColor\"")]
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR_COLOR")]
        TextureTypeMayaSpecularColor = 0x18,
        [Obsolete("Deprecated in favour of \"MayaSpecularRoughness\"")]
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR_ROUGHNESS")]
        TextureTypeMayaSpecularRoughness = 0x19,
        [Obsolete("Deprecated in favour of \"Anisotropy\"")]
        [NativeName("Name", "aiTextureType_ANISOTROPY")]
        TextureTypeAnisotropy = 0x1A,
        [Obsolete("Deprecated in favour of \"GltfMetallicRoughness\"")]
        [NativeName("Name", "aiTextureType_GLTF_METALLIC_ROUGHNESS")]
        TextureTypeGltfMetallicRoughness = 0x1B,
        [NativeName("Name", "aiTextureType_NONE")]
        None = 0x0,
        [NativeName("Name", "aiTextureType_DIFFUSE")]
        Diffuse = 0x1,
        [NativeName("Name", "aiTextureType_SPECULAR")]
        Specular = 0x2,
        [NativeName("Name", "aiTextureType_AMBIENT")]
        Ambient = 0x3,
        [NativeName("Name", "aiTextureType_EMISSIVE")]
        Emissive = 0x4,
        [NativeName("Name", "aiTextureType_HEIGHT")]
        Height = 0x5,
        [NativeName("Name", "aiTextureType_NORMALS")]
        Normals = 0x6,
        [NativeName("Name", "aiTextureType_SHININESS")]
        Shininess = 0x7,
        [NativeName("Name", "aiTextureType_OPACITY")]
        Opacity = 0x8,
        [NativeName("Name", "aiTextureType_DISPLACEMENT")]
        Displacement = 0x9,
        [NativeName("Name", "aiTextureType_LIGHTMAP")]
        Lightmap = 0xA,
        [NativeName("Name", "aiTextureType_REFLECTION")]
        Reflection = 0xB,
        [NativeName("Name", "aiTextureType_BASE_COLOR")]
        BaseColor = 0xC,
        [NativeName("Name", "aiTextureType_NORMAL_CAMERA")]
        NormalCamera = 0xD,
        [NativeName("Name", "aiTextureType_EMISSION_COLOR")]
        EmissionColor = 0xE,
        [NativeName("Name", "aiTextureType_METALNESS")]
        Metalness = 0xF,
        [NativeName("Name", "aiTextureType_DIFFUSE_ROUGHNESS")]
        DiffuseRoughness = 0x10,
        [NativeName("Name", "aiTextureType_AMBIENT_OCCLUSION")]
        AmbientOcclusion = 0x11,
        [NativeName("Name", "aiTextureType_UNKNOWN")]
        Unknown = 0x12,
        [NativeName("Name", "aiTextureType_SHEEN")]
        Sheen = 0x13,
        [NativeName("Name", "aiTextureType_CLEARCOAT")]
        Clearcoat = 0x14,
        [NativeName("Name", "aiTextureType_TRANSMISSION")]
        Transmission = 0x15,
        [NativeName("Name", "aiTextureType_MAYA_BASE")]
        MayaBase = 0x16,
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR")]
        MayaSpecular = 0x17,
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR_COLOR")]
        MayaSpecularColor = 0x18,
        [NativeName("Name", "aiTextureType_MAYA_SPECULAR_ROUGHNESS")]
        MayaSpecularRoughness = 0x19,
        [NativeName("Name", "aiTextureType_ANISOTROPY")]
        Anisotropy = 0x1A,
        [NativeName("Name", "aiTextureType_GLTF_METALLIC_ROUGHNESS")]
        GltfMetallicRoughness = 0x1B,
    }
}
