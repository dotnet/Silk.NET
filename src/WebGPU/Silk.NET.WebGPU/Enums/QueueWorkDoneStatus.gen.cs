// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUQueueWorkDoneStatus")]
    public enum QueueWorkDoneStatus : int
    {
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Unknown")]
        Unknown = 0x2,
        [NativeName("Name", "WGPUQueueWorkDoneStatus_DeviceLost")]
        DeviceLost = 0x3,
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
