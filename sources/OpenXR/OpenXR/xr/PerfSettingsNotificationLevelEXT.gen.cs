// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerfSettingsNotificationLevelEXT")]
public enum PerfSettingsNotificationLevelEXT : uint
{
    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
    Normal = 0,

    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
    Warning = 25,

    [NativeName("XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
    Impaired = 75,
}
