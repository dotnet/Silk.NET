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
    [NativeName("Name", "VkBufferCreateFlags")]
    public enum BufferCreateFlags : int
    {
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_BINDING_BIT")]
        BufferCreateSparseBindingBit = 1,
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT")]
        BufferCreateSparseResidencyBit = 2,
        [NativeName("Name", "VK_BUFFER_CREATE_SPARSE_ALIASED_BIT")]
        BufferCreateSparseAliasedBit = 4,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
        BufferCreateDeviceAddressCaptureReplayBitExt = 16,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        BufferCreateDeviceAddressCaptureReplayBitKhr = 16,
        [NativeName("Name", "VK_BUFFER_CREATE_RESERVED_5_BIT_NV")]
        BufferCreateReserved5BitNV = 32,
        [NativeName("Name", "VK_BUFFER_CREATE_PROTECTED_BIT")]
        BufferCreateProtectedBit = 8,
        [NativeName("Name", "VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        BufferCreateDeviceAddressCaptureReplayBit = 16,
    }
}
