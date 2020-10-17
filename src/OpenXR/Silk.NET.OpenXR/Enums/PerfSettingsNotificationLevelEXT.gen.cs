// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsNotificationLevelEXT")]
    public enum PerfSettingsNotificationLevelEXT
    {
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_NORMAL_EXT")]
        PerfSettingsNotifLevelNormalExt = 0,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_WARNING_EXT")]
        PerfSettingsNotifLevelWarningExt = 25,
        [NativeName("Name", "XR_PERF_SETTINGS_NOTIF_LEVEL_IMPAIRED_EXT")]
        PerfSettingsNotifLevelImpairedExt = 75,
    }
}
