// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkTensorViewCreateFlagsARM")]
    public enum TensorViewCreateFlagsARM : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DescriptorBufferCaptureReplayBitArm\"")]
        [NativeName("Name", "VK_TENSOR_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
        TensorViewCreateDescriptorBufferCaptureReplayBitArm = 1,
        [NativeName("Name", "VK_TENSOR_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
        DescriptorBufferCaptureReplayBitArm = 1,
    }
}
