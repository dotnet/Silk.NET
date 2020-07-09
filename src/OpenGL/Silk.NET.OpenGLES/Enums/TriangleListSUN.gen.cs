// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TriangleListSUN")]
    public enum TriangleListSUN
    {
        [NativeName("Name", "GL_RESTART_SUN")]
        RestartSun = 0x1,
        [NativeName("Name", "GL_REPLACE_MIDDLE_SUN")]
        ReplaceMiddleSun = 0x2,
        [NativeName("Name", "GL_REPLACE_OLDEST_SUN")]
        ReplaceOldestSun = 0x3,
    }
}
