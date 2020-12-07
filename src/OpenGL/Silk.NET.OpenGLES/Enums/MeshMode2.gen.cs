// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MeshMode2")]
    public enum MeshMode2
    {
        [NativeName("Name", "GL_POINT")]
        Point = 0x1B00,
        [NativeName("Name", "GL_LINE")]
        Line = 0x1B01,
        [NativeName("Name", "GL_FILL")]
        Fill = 0x1B02,
    }
}
