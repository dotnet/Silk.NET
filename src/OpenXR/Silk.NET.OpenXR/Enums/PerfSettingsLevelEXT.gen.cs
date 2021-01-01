// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsLevelEXT")]
    public enum PerfSettingsLevelEXT : int
    {
        [NativeName("Name", "XR_PERF_SETTINGS_LEVEL_POWER_SAVINGS_EXT")]
        PerfSettingsLevelPowerSavingsExt = 0,
        [NativeName("Name", "XR_PERF_SETTINGS_LEVEL_SUSTAINED_LOW_EXT")]
        PerfSettingsLevelSustainedLowExt = 25,
        [NativeName("Name", "XR_PERF_SETTINGS_LEVEL_SUSTAINED_HIGH_EXT")]
        PerfSettingsLevelSustainedHighExt = 50,
        [NativeName("Name", "XR_PERF_SETTINGS_LEVEL_BOOST_EXT")]
        PerfSettingsLevelBoostExt = 75,
    }
}
