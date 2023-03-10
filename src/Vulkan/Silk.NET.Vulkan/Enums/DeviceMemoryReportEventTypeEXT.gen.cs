// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDeviceMemoryReportEventTypeEXT")]
    public enum DeviceMemoryReportEventTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"AllocateExt\"")]
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
        DeviceMemoryReportEventTypeAllocateExt = 0,
        [Obsolete("Deprecated in favour of \"FreeExt\"")]
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
        DeviceMemoryReportEventTypeFreeExt = 1,
        [Obsolete("Deprecated in favour of \"ImportExt\"")]
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
        DeviceMemoryReportEventTypeImportExt = 2,
        [Obsolete("Deprecated in favour of \"UnimportExt\"")]
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
        DeviceMemoryReportEventTypeUnimportExt = 3,
        [Obsolete("Deprecated in favour of \"AllocationFailedExt\"")]
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
        DeviceMemoryReportEventTypeAllocationFailedExt = 4,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
        AllocateExt = 0,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
        FreeExt = 1,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
        ImportExt = 2,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
        UnimportExt = 3,
        [NativeName("Name", "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
        AllocationFailedExt = 4,
    }
}
