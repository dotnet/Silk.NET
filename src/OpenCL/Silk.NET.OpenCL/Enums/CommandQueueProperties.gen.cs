// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_command_queue_properties")]
    public enum CommandQueueProperties : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
        OutOfOrderExecModeEnable = 0x1,
        [NativeName("Name", "CL_QUEUE_PROFILING_ENABLE")]
        ProfilingEnable = 0x2,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE")]
        OnDevice = 0x4,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE_DEFAULT")]
        OnDeviceDefault = 0x8,
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        ThreadLocalExecEnableIntel = 0x80000000,
        [NativeName("Name", "CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
        NoSyncOperationsIntel = 0x20000000,
    }
}
