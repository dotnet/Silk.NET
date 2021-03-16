// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "MatrixMode")]
    public enum MatrixMode : int
    {
        [NativeName("Name", "GL_MODELVIEW")]
        Modelview = 0x1700,
        [NativeName("Name", "GL_MODELVIEW0_EXT")]
        Modelview0Ext = 0x1700,
        [NativeName("Name", "GL_PROJECTION")]
        Projection = 0x1701,
        [NativeName("Name", "GL_TEXTURE")]
        Texture = 0x1702,
    }
}
