// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUInstanceFeatureName")]
    public enum InstanceFeatureName : int
    {
        [NativeName("Name", "WGPUInstanceFeatureName_TimedWaitAny")]
        TimedWaitAny = 0x1,
        [NativeName("Name", "WGPUInstanceFeatureName_ShaderSourceSPIRV")]
        ShaderSourceSpirv = 0x2,
        [NativeName("Name", "WGPUInstanceFeatureName_MultipleDevicesPerAdapter")]
        MultipleDevicesPerAdapter = 0x3,
        [NativeName("Name", "WGPUInstanceFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
