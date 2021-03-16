// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceMemoryReportEventTypeEXT")]
    public enum DeviceMemoryReportEventTypeEXT : int
    {
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
        DeviceMemoryReportEventTypeAllocateExt = 0,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
        DeviceMemoryReportEventTypeFreeExt = 1,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
        DeviceMemoryReportEventTypeImportExt = 2,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
        DeviceMemoryReportEventTypeUnimportExt = 3,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
        DeviceMemoryReportEventTypeAllocationFailedExt = 4,
    }
}
