// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSamplerCreateFlags")]
    public enum SamplerCreateFlags : int
    {
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT")]
        SamplerCreateSubsampledBitExt = 1,
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT")]
        SamplerCreateSubsampledCoarseReconstructionBitExt = 2,
        [NativeName("Name", "VK_SAMPLER_CREATE_RESERVED_3_BIT_AMD")]
        SamplerCreateReserved3BitAmd = 8,
        [NativeName("Name", "VK_SAMPLER_CREATE_RESERVED_2_BIT_EXT")]
        SamplerCreateReserved2BitExt = 4,
        [NativeName("Name", "VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM")]
        SamplerCreateImageProcessingBitQCom = 16,
    }
}
