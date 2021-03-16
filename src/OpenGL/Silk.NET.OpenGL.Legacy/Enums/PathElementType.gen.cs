// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathElementType")]
    public enum PathElementType : int
    {
        [NativeName("Name", "GL_UTF8_NV")]
        Utf8NV = 0x909A,
        [NativeName("Name", "GL_UTF16_NV")]
        Utf16NV = 0x909B,
    }
}
