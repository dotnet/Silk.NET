// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClipControlOrigin")]
    public enum ClipControlOrigin
    {
        [NativeName("Name", "GL_LOWER_LEFT")]
        LowerLeft = 0x8CA1,
        [NativeName("Name", "GL_UPPER_LEFT")]
        UpperLeft = 0x8CA2,
    }
}
