// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPURequestAdapterStatus")]
    public enum RequestAdapterStatus : int
    {
        [NativeName("Name", "WGPURequestAdapterStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPURequestAdapterStatus_Unavailable")]
        Unavailable = 0x1,
        [NativeName("Name", "WGPURequestAdapterStatus_Error")]
        Error = 0x2,
        [NativeName("Name", "WGPURequestAdapterStatus_Unknown")]
        Unknown = 0x3,
        [NativeName("Name", "WGPURequestAdapterStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
