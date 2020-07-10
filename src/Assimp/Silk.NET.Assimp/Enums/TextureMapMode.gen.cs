// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureMapMode")]
    public enum TextureMapMode
    {
        [NativeName("Name", "aiTextureMapMode_Wrap")]
        TextureMapModeWrap = 0x0,
        [NativeName("Name", "aiTextureMapMode_Clamp")]
        TextureMapModeClamp = 0x1,
        [NativeName("Name", "aiTextureMapMode_Decal")]
        TextureMapModeDecal = 0x3,
        [NativeName("Name", "aiTextureMapMode_Mirror")]
        TextureMapModeMirror = 0x2,
    }
}
