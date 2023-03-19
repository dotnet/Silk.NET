// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUPowerPreference")]
    public enum PowerPreference : int
    {
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
