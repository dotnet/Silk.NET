// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SwizzleOpATI")]
    public enum SwizzleOpATI : int
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
