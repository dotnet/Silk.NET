// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerfSettingsDomainEXT")]
[SupportedApiProfile("openxr")]
public enum PerfSettingsDomainEXT : uint
{
    [NativeName("XR_PERF_SETTINGS_DOMAIN_CPU_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings", "XR_EXT_thermal_query"])]
    Cpu = 1,

    [NativeName("XR_PERF_SETTINGS_DOMAIN_GPU_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings", "XR_EXT_thermal_query"])]
    Gpu = 2,
}
