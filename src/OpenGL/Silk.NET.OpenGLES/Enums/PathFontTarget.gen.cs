// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathFontTarget")]
    public enum PathFontTarget : int
    {
        [NativeName("Name", "GL_STANDARD_FONT_NAME_NV")]
        StandardFontNameNV = 0x9072,
        [NativeName("Name", "GL_SYSTEM_FONT_NAME_NV")]
        SystemFontNameNV = 0x9073,
        [NativeName("Name", "GL_FILE_NAME_NV")]
        FileNameNV = 0x9074,
    }
}
