// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerCreateFlags")]
[Flags]
public enum SamplerCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT")]
    SubsampledBitEXT = 0x1,

    [NativeName("VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT")]
    SubsampledCoarseReconstructionBitEXT = 0x2,

    [NativeName("VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
    DescriptorBufferCaptureReplayBitEXT = 0x8,

    [NativeName("VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT")]
    NonSeamlessCubeMapBitEXT = 0x4,

    [NativeName("VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM")]
    ImageProcessingBitQCOM = 0x10,
}
