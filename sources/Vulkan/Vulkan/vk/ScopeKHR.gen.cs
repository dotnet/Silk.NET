// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkScopeKHR")]
public enum ScopeKHR : uint
{
    [NativeName("VK_SCOPE_DEVICE_KHR")]
    Device = 1,

    [NativeName("VK_SCOPE_WORKGROUP_KHR")]
    Workgroup = 2,

    [NativeName("VK_SCOPE_SUBGROUP_KHR")]
    Subgroup = 3,

    [NativeName("VK_SCOPE_QUEUE_FAMILY_KHR")]
    QueueFamily = 5,

    [NativeName("VK_SCOPE_DEVICE_NV")]
    DeviceNV = Device,

    [NativeName("VK_SCOPE_WORKGROUP_NV")]
    WorkgroupNV = Workgroup,

    [NativeName("VK_SCOPE_SUBGROUP_NV")]
    SubgroupNV = Subgroup,

    [NativeName("VK_SCOPE_QUEUE_FAMILY_NV")]
    QueueFamilyNV = QueueFamily,
}
