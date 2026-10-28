// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerfSettingsSubDomainEXT")]
[SupportedApiProfile("openxr")]
public enum PerfSettingsSubDomainEXT : uint
{
    [NativeName("XR_PERF_SETTINGS_SUB_DOMAIN_COMPOSITING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    Compositing = 1,

    [NativeName("XR_PERF_SETTINGS_SUB_DOMAIN_RENDERING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    Rendering = 2,

    [NativeName("XR_PERF_SETTINGS_SUB_DOMAIN_THERMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    Thermal = 3,
}
