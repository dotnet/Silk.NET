// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPULoggingType")]
    public enum LoggingType : int
    {
        [NativeName("Name", "WGPULoggingType_Verbose")]
        Verbose = 0x1,
        [NativeName("Name", "WGPULoggingType_Info")]
        Info = 0x2,
        [NativeName("Name", "WGPULoggingType_Warning")]
        Warning = 0x3,
        [NativeName("Name", "WGPULoggingType_Error")]
        Error = 0x4,
        [NativeName("Name", "WGPULoggingType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
