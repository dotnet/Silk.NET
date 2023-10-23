// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [Flags]
    [NativeName("Name", "spvc_hlsl_binding_flag_bits")]
    public enum HlslBindingFlagBits : int
    {
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_NONE_BIT")]
        NoneBit = 0x0,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT")]
        PushConstantBit = 0x1,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_CBV_BIT")]
        CbvBit = 0x2,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_SRV_BIT")]
        SrvBit = 0x4,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_UAV_BIT")]
        UavBit = 0x8,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_SAMPLER_BIT")]
        SamplerBit = 0x10,
        [NativeName("Name", "SPVC_HLSL_BINDING_AUTO_ALL")]
        All = 0x7FFFFFFF,
    }
}
