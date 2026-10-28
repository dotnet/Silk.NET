// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceMemoryReportEventTypeEXT")]
public enum DeviceMemoryReportEventTypeEXT : uint
{
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
    Allocate = 0,

    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
    Free = 1,

    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
    Import = 2,

    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
    Unimport = 3,

    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
    AllocationFailed = 4,
}
