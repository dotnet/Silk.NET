// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureMapping")]
    public enum TextureMapping : int
    {
        [NativeName("Name", "aiTextureMapping_UV")]
        TextureMappingUV = 0x0,
        [NativeName("Name", "aiTextureMapping_SPHERE")]
        TextureMappingSphere = 0x1,
        [NativeName("Name", "aiTextureMapping_CYLINDER")]
        TextureMappingCylinder = 0x2,
        [NativeName("Name", "aiTextureMapping_BOX")]
        TextureMappingBox = 0x3,
        [NativeName("Name", "aiTextureMapping_PLANE")]
        TextureMappingPlane = 0x4,
        [NativeName("Name", "aiTextureMapping_OTHER")]
        TextureMappingOther = 0x5,
    }
}
