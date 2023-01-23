// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SamplerParameterF")]
    public enum SamplerParameterF : int
    {
        [Obsolete("Deprecated in favour of \"BorderColor\"")]
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR")]
        TextureBorderColor = 0x1004,
        [Obsolete("Deprecated in favour of \"MinLod\"")]
        [NativeName("Name", "GL_TEXTURE_MIN_LOD")]
        TextureMinLod = 0x813A,
        [Obsolete("Deprecated in favour of \"MaxLod\"")]
        [NativeName("Name", "GL_TEXTURE_MAX_LOD")]
        TextureMaxLod = 0x813B,
        [Obsolete("Deprecated in favour of \"MaxAnisotropy\"")]
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY")]
        TextureMaxAnisotropy = 0x84FE,
        [Obsolete("Deprecated in favour of \"LodBias\"")]
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS")]
        TextureLodBias = 0x8501,
        [Obsolete("Deprecated in favour of \"UnnormalizedCoordinatesArm\"")]
        [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
        TextureUnnormalizedCoordinatesArm = 0x8F6A,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR")]
        BorderColor = 0x1004,
        [NativeName("Name", "GL_TEXTURE_MIN_LOD")]
        MinLod = 0x813A,
        [NativeName("Name", "GL_TEXTURE_MAX_LOD")]
        MaxLod = 0x813B,
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY")]
        MaxAnisotropy = 0x84FE,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS")]
        LodBias = 0x8501,
        [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
        UnnormalizedCoordinatesArm = 0x8F6A,
    }
}
