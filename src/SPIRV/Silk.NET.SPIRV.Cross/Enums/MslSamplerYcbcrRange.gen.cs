// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_ycbcr_range")]
    public enum MslSamplerYcbcrRange : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        ItuFull = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        ItuNarrow = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_RANGE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
