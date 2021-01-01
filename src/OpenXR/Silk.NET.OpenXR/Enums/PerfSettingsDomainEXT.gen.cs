// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsDomainEXT")]
    public enum PerfSettingsDomainEXT : int
    {
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_CPU_EXT")]
        PerfSettingsDomainCpuExt = 1,
        [NativeName("Name", "XR_PERF_SETTINGS_DOMAIN_GPU_EXT")]
        PerfSettingsDomainGpuExt = 2,
    }
}
