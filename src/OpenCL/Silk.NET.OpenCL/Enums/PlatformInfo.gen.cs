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
        PlatformProfile = 0x900,
        [NativeName("Name", "CL_PLATFORM_VERSION")]
        PlatformVersion = 0x901,
        [NativeName("Name", "CL_PLATFORM_NAME")]
        PlatformName = 0x902,
        [NativeName("Name", "CL_PLATFORM_VENDOR")]
        PlatformVendor = 0x903,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS")]
        PlatformExtensions = 0x904,
        [NativeName("Name", "CL_PLATFORM_HOST_TIMER_RESOLUTION")]
        PlatformHostTimerResolution = 0x905,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION_KHR")]
        PlatformNumericVersionKhr = 0x906,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION")]
        PlatformNumericVersion = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION_KHR")]
        PlatformExtensionsWithVersionKhr = 0x907,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION")]
        PlatformExtensionsWithVersion = 0x907,
        [NativeName("Name", "CL_PLATFORM_ICD_SUFFIX_KHR")]
        PlatformIcdSuffixKhr = 0x920,
    }
}
