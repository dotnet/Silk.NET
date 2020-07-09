// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SwizzleOpATI")]
    public enum SwizzleOpATI
    {
        [NativeName("Name", "GL_SWIZZLE_STR_ATI")]
        SwizzleStrAti = 0x8976,
        [NativeName("Name", "GL_SWIZZLE_STQ_ATI")]
        SwizzleStqAti = 0x8977,
        [NativeName("Name", "GL_SWIZZLE_STR_DR_ATI")]
        SwizzleStrDRAti = 0x8978,
        [NativeName("Name", "GL_SWIZZLE_STQ_DQ_ATI")]
        SwizzleStqDQAti = 0x8979,
    }
}
