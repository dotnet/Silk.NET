// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathFontStyle")]
    public enum PathFontStyle
    {
        [NativeName("Name", "GL_BOLD_BIT_NV")]
        BoldBitNV = 0x1,
        [NativeName("Name", "GL_ITALIC_BIT_NV")]
        ItalicBitNV = 0x2,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
    }
}
