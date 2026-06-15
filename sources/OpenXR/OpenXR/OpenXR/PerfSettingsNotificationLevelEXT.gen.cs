// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerfSettingsNotificationLevelEXT")]
[SupportedApiProfile("openxr")]
public enum PerfSettingsNotificationLevelEXT : uint
{
    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings", "XR_EXT_thermal_query"])]
    NotifLevelNormal = 0,

    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings", "XR_EXT_thermal_query"])]
    NotifLevelWarning = 25,

    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings", "XR_EXT_thermal_query"])]
    NotifLevelImpaired = 75,
}
