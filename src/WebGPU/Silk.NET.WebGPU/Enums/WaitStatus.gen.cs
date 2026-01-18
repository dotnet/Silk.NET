// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUWaitStatus")]
    public enum WaitStatus : int
    {
        [NativeName("Name", "WGPUWaitStatus_Success")]
        Success = 0x1,
        [NativeName("Name", "WGPUWaitStatus_TimedOut")]
        TimedOut = 0x2,
        [NativeName("Name", "WGPUWaitStatus_Error")]
        Error = 0x3,
        [NativeName("Name", "WGPUWaitStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
