// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_component_swizzle")]
    public enum MslComponentSwizzle : int
    {
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_IDENTITY")]
        Identity = 0x0,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_ONE")]
        One = 0x2,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_R")]
        R = 0x3,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_G")]
        G = 0x4,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_B")]
        B = 0x5,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_A")]
        A = 0x6,
        [NativeName("Name", "SPVC_MSL_COMPONENT_SWIZZLE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
