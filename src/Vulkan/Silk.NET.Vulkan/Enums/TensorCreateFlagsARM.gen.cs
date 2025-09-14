// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkTensorCreateFlagsARM")]
    public enum TensorCreateFlagsARM : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MutableFormatBitArm\"")]
        [NativeName("Name", "VK_TENSOR_CREATE_MUTABLE_FORMAT_BIT_ARM")]
        TensorCreateMutableFormatBitArm = 1,
        [Obsolete("Deprecated in favour of \"ProtectedBitArm\"")]
        [NativeName("Name", "VK_TENSOR_CREATE_PROTECTED_BIT_ARM")]
        TensorCreateProtectedBitArm = 2,
        [Obsolete("Deprecated in favour of \"DescriptorBufferCaptureReplayBitArm\"")]
        [NativeName("Name", "VK_TENSOR_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
        TensorCreateDescriptorBufferCaptureReplayBitArm = 4,
        [NativeName("Name", "VK_TENSOR_CREATE_MUTABLE_FORMAT_BIT_ARM")]
        MutableFormatBitArm = 1,
        [NativeName("Name", "VK_TENSOR_CREATE_PROTECTED_BIT_ARM")]
        ProtectedBitArm = 2,
        [NativeName("Name", "VK_TENSOR_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM")]
        DescriptorBufferCaptureReplayBitArm = 4,
    }
}
