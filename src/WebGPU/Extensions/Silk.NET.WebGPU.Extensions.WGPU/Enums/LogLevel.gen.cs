// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPULogLevel")]
    public enum LogLevel : int
    {
        [NativeName("Name", "WGPULogLevel_Off")]
        Off = 0x0,
        [NativeName("Name", "WGPULogLevel_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPULogLevel_Warn")]
        Warn = 0x2,
        [NativeName("Name", "WGPULogLevel_Info")]
        Info = 0x3,
        [NativeName("Name", "WGPULogLevel_Debug")]
        Debug = 0x4,
        [NativeName("Name", "WGPULogLevel_Trace")]
        Trace = 0x5,
        [NativeName("Name", "WGPULogLevel_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
