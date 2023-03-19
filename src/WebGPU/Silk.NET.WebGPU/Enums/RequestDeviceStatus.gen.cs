// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPURequestDeviceStatus")]
    public enum RequestDeviceStatus : int
    {
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
