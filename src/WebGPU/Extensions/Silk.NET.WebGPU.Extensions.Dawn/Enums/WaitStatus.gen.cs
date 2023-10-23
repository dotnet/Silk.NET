// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUWaitStatus")]
    public enum WaitStatus : int
    {
        [NativeName("Name", "WGPUWaitStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUWaitStatus_TimedOut")]
        TimedOut = 0x1,
        [NativeName("Name", "WGPUWaitStatus_UnsupportedTimeout")]
        UnsupportedTimeout = 0x2,
        [NativeName("Name", "WGPUWaitStatus_UnsupportedCount")]
        UnsupportedCount = 0x3,
        [NativeName("Name", "WGPUWaitStatus_UnsupportedMixedSources")]
        UnsupportedMixedSources = 0x4,
        [NativeName("Name", "WGPUWaitStatus_Unknown")]
        Unknown = 0x5,
        [NativeName("Name", "WGPUWaitStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
