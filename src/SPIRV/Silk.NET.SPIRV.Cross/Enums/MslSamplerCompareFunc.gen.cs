// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_compare_func")]
    public enum MslSamplerCompareFunc : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_NEVER")]
        Never = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_LESS")]
        Less = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_LESS_EQUAL")]
        LessEqual = 0x2,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_GREATER")]
        Greater = 0x3,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_GREATER_EQUAL")]
        GreaterEqual = 0x4,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_EQUAL")]
        Equal = 0x5,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_NOT_EQUAL")]
        NotEqual = 0x6,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_ALWAYS")]
        Always = 0x7,
        [NativeName("Name", "SPVC_MSL_SAMPLER_COMPARE_FUNC_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
