// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUPowerPreference")]
    public enum PowerPreference : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUPowerPreference_Undefined")]
        PowerPreferenceUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"LowPower\"")]
        [NativeName("Name", "WGPUPowerPreference_LowPower")]
        PowerPreferenceLowPower = 0x1,
        [Obsolete("Deprecated in favour of \"HighPerformance\"")]
        [NativeName("Name", "WGPUPowerPreference_HighPerformance")]
        PowerPreferenceHighPerformance = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUPowerPreference_Force32")]
        PowerPreferenceForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUPowerPreference_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUPowerPreference_LowPower")]
        LowPower = 0x1,
        [NativeName("Name", "WGPUPowerPreference_HighPerformance")]
        HighPerformance = 0x2,
        [NativeName("Name", "WGPUPowerPreference_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
