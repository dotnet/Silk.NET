// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureFlags")]
    public enum TextureFlags
    {
        [NativeName("Name", "aiTextureFlags_Invert")]
        TextureFlagsInvert = 0x1,
        [NativeName("Name", "aiTextureFlags_UseAlpha")]
        TextureFlagsUseAlpha = 0x2,
        [NativeName("Name", "aiTextureFlags_IgnoreAlpha")]
        TextureFlagsIgnoreAlpha = 0x4,
    }
}
