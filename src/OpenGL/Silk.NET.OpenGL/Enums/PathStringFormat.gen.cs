// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PathStringFormat")]
    public enum PathStringFormat
    {
        [NativeName("Name", "GL_PATH_FORMAT_SVG_NV")]
        PathFormatSvgNV = 0x9070,
        [NativeName("Name", "GL_PATH_FORMAT_PS_NV")]
        PathFormatPSNV = 0x9071,
    }
}
