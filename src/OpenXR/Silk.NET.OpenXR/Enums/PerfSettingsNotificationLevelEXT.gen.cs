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
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
        PerfSettingsNotifLevelNormalExt = 0,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
        PerfSettingsNotifLevelWarningExt = 25,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
        PerfSettingsNotifLevelImpairedExt = 75,
    }
}
