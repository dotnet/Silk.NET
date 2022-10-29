// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUDeviceLostReason")]
    public enum DeviceLostReason : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUDeviceLostReason_Undefined")]
        DeviceLostReasonUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Destroyed\"")]
        [NativeName("Name", "WGPUDeviceLostReason_Destroyed")]
        DeviceLostReasonDestroyed = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUDeviceLostReason_Force32")]
        DeviceLostReasonForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUDeviceLostReason_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUDeviceLostReason_Destroyed")]
        Destroyed = 0x1,
        [NativeName("Name", "WGPUDeviceLostReason_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
