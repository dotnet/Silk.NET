// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsDomainEXT")]
    public enum PerfSettingsDomainEXT : int
    {
        [Obsolete("Deprecated in favour of \"CpuExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_CPU_EXT")]
        PerfSettingsDomainCpuExt = 1,
        [Obsolete("Deprecated in favour of \"GpuExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_GPU_EXT")]
        PerfSettingsDomainGpuExt = 2,
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_CPU_EXT")]
        CpuExt = 1,
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_GPU_EXT")]
        GpuExt = 2,
    }
}
