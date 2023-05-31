// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_mip_filter")]
    public enum MslSamplerMipFilter : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_MIP_FILTER_NONE")]
        None = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_MIP_FILTER_NEAREST")]
        Nearest = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_MIP_FILTER_LINEAR")]
        Linear = 0x2,
        [NativeName("Name", "SPVC_MSL_SAMPLER_MIP_FILTER_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
