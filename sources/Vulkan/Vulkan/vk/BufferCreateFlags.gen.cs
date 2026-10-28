// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferCreateFlags")]
[Flags]
public enum BufferCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_BUFFER_CREATE_SPARSE_BINDING_BIT")]
    SparseBindingBit = 0x1,

    [NativeName("VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT")]
    SparseResidencyBit = 0x2,

    [NativeName("VK_BUFFER_CREATE_SPARSE_ALIASED_BIT")]
    SparseAliasedBit = 0x4,

    [NativeName("VK_BUFFER_CREATE_PROTECTED_BIT")]
    ProtectedBit = 0x8,

    [NativeName("VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
    DeviceAddressCaptureReplayBit = 0x10,

    [NativeName("VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
    DescriptorBufferCaptureReplayBitEXT = 0x20,

    [NativeName("VK_BUFFER_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR")]
    VideoProfileIndependentBitKHR = 0x40,

    [NativeName("VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
    DeviceAddressCaptureReplayBitEXT = DeviceAddressCaptureReplayBit,

    [NativeName("VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
    DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,
}
