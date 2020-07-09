// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ParameterRangeEXT")]
    public enum ParameterRangeEXT
    {
        [NativeName("Name", "GL_NORMALIZED_RANGE_EXT")]
        NormalizedRangeExt = 0x87E0,
        [NativeName("Name", "GL_FULL_RANGE_EXT")]
        FullRangeExt = 0x87E1,
    }
}
