// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "CombinerScaleNV")]
    public enum CombinerScaleNV : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_SCALE_BY_TWO_NV")]
        ScaleByTwoNV = 0x853E,
        [NativeName("Name", "GL_SCALE_BY_FOUR_NV")]
        ScaleByFourNV = 0x853F,
        [NativeName("Name", "GL_SCALE_BY_ONE_HALF_NV")]
        ScaleByOneHalfNV = 0x8540,
    }
}
