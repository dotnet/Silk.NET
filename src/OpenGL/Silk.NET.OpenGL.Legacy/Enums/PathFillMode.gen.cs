// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathFillMode")]
    public enum PathFillMode
    {
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        PathFillModeNV = 0x9080,
        [NativeName("Name", "GL_COUNT_UP_NV")]
        CountUpNV = 0x9088,
        [NativeName("Name", "GL_COUNT_DOWN_NV")]
        CountDownNV = 0x9089,
    }
}
