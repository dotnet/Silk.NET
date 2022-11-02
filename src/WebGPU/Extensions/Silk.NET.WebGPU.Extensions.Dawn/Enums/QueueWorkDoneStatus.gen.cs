// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUQueueWorkDoneStatus")]
    public enum QueueWorkDoneStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Success\"")]
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Success")]
        QueueWorkDoneStatusSuccess = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Error")]
        QueueWorkDoneStatusError = 0x1,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Unknown")]
        QueueWorkDoneStatusUnknown = 0x2,
        [Obsolete("Deprecated in favour of \"DeviceLost\"")]
        [NativeName("Name", "WGPUQueueWorkDoneStatus_DeviceLost")]
        QueueWorkDoneStatusDeviceLost = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUQueueWorkDoneStatus_Force32")]
        QueueWorkDoneStatusForce32 = 0x7FFFFFFF,
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
