// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBufferCreateFlags")]
    public enum BufferCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SparseBindingBit\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_BINDING_BIT")]
        BufferCreateSparseBindingBit = 1,
        [Obsolete("Deprecated in favour of \"SparseResidencyBit\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT")]
        BufferCreateSparseResidencyBit = 2,
        [Obsolete("Deprecated in favour of \"SparseAliasedBit\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_ALIASED_BIT")]
        BufferCreateSparseAliasedBit = 4,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
        BufferCreateDeviceAddressCaptureReplayBitExt = 16,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        BufferCreateDeviceAddressCaptureReplayBitKhr = 16,
        [Obsolete("Deprecated in favour of \"DescriptorBufferCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        BufferCreateDescriptorBufferCaptureReplayBitExt = 32,
        [Obsolete("Deprecated in favour of \"VideoProfileIndependentBitKhr\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
        BufferCreateVideoProfileIndependentBitKhr = 64,
        [Obsolete("Deprecated in favour of \"ProtectedBit\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_PROTECTED_BIT")]
        BufferCreateProtectedBit = 8,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBit\"")]
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        BufferCreateDeviceAddressCaptureReplayBit = 16,
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_BINDING_BIT")]
        SparseBindingBit = 1,
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT")]
        SparseResidencyBit = 2,
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_ALIASED_BIT")]
        SparseAliasedBit = 4,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
        DeviceAddressCaptureReplayBitExt = 16,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        DeviceAddressCaptureReplayBitKhr = 16,
        [NativeName("Name", "VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        DescriptorBufferCaptureReplayBitExt = 32,
        [NativeName("Name", "VK_BUFFER_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
        VideoProfileIndependentBitKhr = 64,
        [NativeName("Name", "VK_BUFFER_CREATE_PROTECTED_BIT")]
        ProtectedBit = 8,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        DeviceAddressCaptureReplayBit = 16,
    }
}
