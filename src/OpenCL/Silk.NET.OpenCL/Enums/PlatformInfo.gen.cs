// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_platform_info")]
    public enum PlatformInfo : int
    {
        [NativeName("Name", "CL_PLATFORM_PROFILE")]
        Profile = 0x900,
        [NativeName("Name", "CL_PLATFORM_VERSION")]
        Version = 0x901,
        [NativeName("Name", "CL_PLATFORM_NAME")]
        Name = 0x902,
        [NativeName("Name", "CL_PLATFORM_VENDOR")]
        Vendor = 0x903,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS")]
        Extensions = 0x904,
        [NativeName("Name", "CL_PLATFORM_HOST_TIMER_RESOLUTION")]
        HostTimerResolution = 0x905,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION")]
        NumericVersion = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION")]
        ExtensionsWithVersion = 0x907,
        [NativeName("Name", "CL_PLATFORM_ICD_SUFFIX_KHR")]
        IcdSuffixKhr = 0x920,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION_KHR")]
        NumericVersionKhr = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION_KHR")]
        ExtensionsWithVersionKhr = 0x907,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_TYPES_KHR")]
        SemaphoreTypesKhr = 0x2036,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        SemaphoreImportHandleTypesKhr = 0x2037,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        SemaphoreExportHandleTypesKhr = 0x2038,
        [NativeName("Name", "CL_PLATFORM_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        ExternalMemoryImportHandleTypesKhr = 0x2044,
        [NativeName("Name", "CL_PLATFORM_COMMAND_BUFFER_CAPABILITIES_KHR")]
        CommandBufferCapabilitiesKhr = 0x908,
    }
}
