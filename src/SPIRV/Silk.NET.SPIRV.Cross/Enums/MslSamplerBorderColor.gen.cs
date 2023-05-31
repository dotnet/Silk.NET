// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_border_color")]
    public enum MslSamplerBorderColor : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_BORDER_COLOR_TRANSPARENT_BLACK")]
        TransparentBlack = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_BORDER_COLOR_OPAQUE_BLACK")]
        OpaqueBlack = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_BORDER_COLOR_OPAQUE_WHITE")]
        OpaqueWhite = 0x2,
        [NativeName("Name", "SPVC_MSL_SAMPLER_BORDER_COLOR_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
