// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsSubDomainEXT")]
    public enum PerfSettingsSubDomainEXT : int
    {
        [Obsolete("Deprecated in favour of \"CompositingExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_COMPOSITING_EXT")]
        PerfSettingsSubDomainCompositingExt = 1,
        [Obsolete("Deprecated in favour of \"RenderingExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_RENDERING_EXT")]
        PerfSettingsSubDomainRenderingExt = 2,
        [Obsolete("Deprecated in favour of \"ThermalExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_THERMAL_EXT")]
        PerfSettingsSubDomainThermalExt = 3,
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_COMPOSITING_EXT")]
        CompositingExt = 1,
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_RENDERING_EXT")]
        RenderingExt = 2,
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_THERMAL_EXT")]
        ThermalExt = 3,
    }
}
