// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_address")]
    public enum MslSamplerAddress : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_ZERO")]
        ClampToZero = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE")]
        ClampToEdge = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_BORDER")]
        ClampToBorder = 0x2,
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_REPEAT")]
        Repeat = 0x3,
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_MIRRORED_REPEAT")]
        MirroredRepeat = 0x4,
        [NativeName("Name", "SPVC_MSL_SAMPLER_ADDRESS_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
