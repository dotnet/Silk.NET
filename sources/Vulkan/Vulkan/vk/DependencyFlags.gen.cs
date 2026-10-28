// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDependencyFlags")]
[Flags]
public enum DependencyFlags : uint
{
    None = 0x0,

    [NativeName("VK_DEPENDENCY_BY_REGION_BIT")]
    ByRegionBit = 0x1,

    [NativeName("VK_DEPENDENCY_DEVICE_GROUP_BIT")]
    DeviceGroupBit = 0x4,

    [NativeName("VK_DEPENDENCY_VIEW_LOCAL_BIT")]
    ViewLocalBit = 0x2,

    [NativeName("VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT")]
    FeedbackLoopBitEXT = 0x8,

    [NativeName("VK_DEPENDENCY_QUEUE_FAMILY_OWNERSHIP_TRANSFER_USE_ALL_STAGES_BIT_KHR")]
    QueueFamilyOwnershipTransferUseAllStagesBitKHR = 0x20,

    [NativeName("VK_DEPENDENCY_ASYMMETRIC_EVENT_BIT_KHR")]
    AsymmetricEventBitKHR = 0x40,

    [NativeName("VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR")]
    ViewLocalBitKHR = ViewLocalBit,

    [NativeName("VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR")]
    DeviceGroupBitKHR = DeviceGroupBit,
}
