// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsNotificationLevelEXT")]
    public enum PerfSettingsNotificationLevelEXT : int
    {
        [Obsolete("Deprecated in favour of \"NormalExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
        PerfSettingsNotifLevelNormalExt = 0,
        [Obsolete("Deprecated in favour of \"WarningExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
        PerfSettingsNotifLevelWarningExt = 25,
        [Obsolete("Deprecated in favour of \"ImpairedExt\"")]
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
        PerfSettingsNotifLevelImpairedExt = 75,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
        NormalExt = 0,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
        WarningExt = 25,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
        ImpairedExt = 75,
    }
}
