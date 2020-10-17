// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathColor")]
    public enum PathColor
    {
        [NativeName("Name", "GL_PRIMARY_COLOR_NV")]
        PrimaryColorNV = 0x852C,
        [NativeName("Name", "GL_SECONDARY_COLOR_NV")]
        SecondaryColorNV = 0x852D,
        [NativeName("Name", "GL_PRIMARY_COLOR")]
        PrimaryColor = 0x8577,
    }
}
