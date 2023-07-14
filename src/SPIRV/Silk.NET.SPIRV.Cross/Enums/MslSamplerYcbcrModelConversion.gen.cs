// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_sampler_ycbcr_model_conversion")]
    public enum MslSamplerYcbcrModelConversion : int
    {
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY")]
        RgbIdentity = 0x0,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY")]
        YcbcrIdentity = 0x1,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_BT_709")]
        YcbcrBT709 = 0x2,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_BT_601")]
        YcbcrBT601 = 0x3,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_BT_2020")]
        YcbcrBT2020 = 0x4,
        [NativeName("Name", "SPVC_MSL_SAMPLER_YCBCR_MODEL_CONVERSION_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
