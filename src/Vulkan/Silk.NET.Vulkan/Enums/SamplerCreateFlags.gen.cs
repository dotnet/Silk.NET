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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SubsampledBitExt\"")]
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT")]
        SamplerCreateSubsampledBitExt = 1,
        [Obsolete("Deprecated in favour of \"SubsampledCoarseReconstructionBitExt\"")]
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT")]
        SamplerCreateSubsampledCoarseReconstructionBitExt = 2,
        [Obsolete("Deprecated in favour of \"DescriptorBufferCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        SamplerCreateDescriptorBufferCaptureReplayBitExt = 8,
        [Obsolete("Deprecated in favour of \"NonSeamlessCubeMapBitExt\"")]
        [NativeName("Name", "VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT")]
        SamplerCreateNonSeamlessCubeMapBitExt = 4,
        [Obsolete("Deprecated in favour of \"ImageProcessingBitQCom\"")]
        [NativeName("Name", "VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM")]
        SamplerCreateImageProcessingBitQCom = 16,
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT")]
        SubsampledBitExt = 1,
        [NativeName("Name", "VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT")]
        SubsampledCoarseReconstructionBitExt = 2,
        [NativeName("Name", "VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        DescriptorBufferCaptureReplayBitExt = 8,
        [NativeName("Name", "VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT")]
        NonSeamlessCubeMapBitExt = 4,
        [NativeName("Name", "VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM")]
        ImageProcessingBitQCom = 16,
    }
}
