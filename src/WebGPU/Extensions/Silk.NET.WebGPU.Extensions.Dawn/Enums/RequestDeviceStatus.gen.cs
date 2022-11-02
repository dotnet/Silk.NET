// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPURequestDeviceStatus")]
    public enum RequestDeviceStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Success\"")]
        [NativeName("Name", "WGPURequestDeviceStatus_Success")]
        RequestDeviceStatusSuccess = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPURequestDeviceStatus_Error")]
        RequestDeviceStatusError = 0x1,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPURequestDeviceStatus_Unknown")]
        RequestDeviceStatusUnknown = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPURequestDeviceStatus_Force32")]
        RequestDeviceStatusForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPURequestDeviceStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPURequestDeviceStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPURequestDeviceStatus_Unknown")]
        Unknown = 0x2,
        [NativeName("Name", "WGPURequestDeviceStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
