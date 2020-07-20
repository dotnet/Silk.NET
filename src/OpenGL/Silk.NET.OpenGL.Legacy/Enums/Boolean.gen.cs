// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "Boolean")]
    public enum Boolean
    {
        [NativeName("Name", "GL_FALSE")]
        False = 0x0,
        [NativeName("Name", "GL_TRUE")]
        True = 0x1,
    }
}
