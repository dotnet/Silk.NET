// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "Buffer")]
    public enum Buffer
    {
        [NativeName("Name", "GL_COLOR")]
        Color = 0x1800,
        [NativeName("Name", "GL_DEPTH")]
        Depth = 0x1801,
        [NativeName("Name", "GL_STENCIL")]
        Stencil = 0x1802,
    }
}
