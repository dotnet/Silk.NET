// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SeparableTargetEXT")]
    public enum SeparableTargetEXT
    {
        [NativeName("Name", "GL_SEPARABLE_2D")]
        Separable2D = 0x8012,
        [NativeName("Name", "GL_SEPARABLE_2D_EXT")]
        Separable2DExt = 0x8012,
    }
}
