// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSamplerCreateFlags")]
    public enum SamplerCreateFlags
    {
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT")]
        SamplerCreateSubsampledBitExt = 1,
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT")]
        SamplerCreateSubsampledCoarseReconstructionBitExt = 2,
    }
}
