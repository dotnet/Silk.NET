// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_filter")]
    public enum MslSamplerFilter : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_FILTER_NEAREST")]
        Nearest = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_FILTER_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_FILTER_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
