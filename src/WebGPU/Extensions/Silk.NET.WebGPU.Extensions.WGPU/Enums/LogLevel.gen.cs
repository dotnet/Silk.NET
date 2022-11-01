// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Flags]
    [NativeName("Name", "WGPULogLevel")]
    public enum LogLevel : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Off\"")]
        [NativeName("Name", "WGPULogLevel_Off")]
        LogLevelOff = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPULogLevel_Error")]
        LogLevelError = 0x1,
        [Obsolete("Deprecated in favour of \"Warn\"")]
        [NativeName("Name", "WGPULogLevel_Warn")]
        LogLevelWarn = 0x2,
        [Obsolete("Deprecated in favour of \"Info\"")]
        [NativeName("Name", "WGPULogLevel_Info")]
        LogLevelInfo = 0x3,
        [Obsolete("Deprecated in favour of \"Debug\"")]
        [NativeName("Name", "WGPULogLevel_Debug")]
        LogLevelDebug = 0x4,
        [Obsolete("Deprecated in favour of \"Trace\"")]
        [NativeName("Name", "WGPULogLevel_Trace")]
        LogLevelTrace = 0x5,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPULogLevel_Force32")]
        LogLevelForce32 = 0x7FFFFFFF,
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
