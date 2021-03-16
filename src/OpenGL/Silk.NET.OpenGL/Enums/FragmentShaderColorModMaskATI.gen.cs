// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentShaderColorModMaskATI")]
    public enum FragmentShaderColorModMaskATI : int
    {
        [NativeName("Name", "GL_COMP_BIT_ATI")]
        CompBitAti = 0x2,
        [NativeName("Name", "GL_NEGATE_BIT_ATI")]
        NegateBitAti = 0x4,
        [NativeName("Name", "GL_BIAS_BIT_ATI")]
        BiasBitAti = 0x8,
    }
}
