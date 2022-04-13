// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_command_queue_properties")]
    public enum CommandQueueProperties : ulong
    {
        [NativeName("Name", "CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
        QueueOutOfOrderExecModeEnable = 0x1,
        [NativeName("Name", "CL_QUEUE_PROFILING_ENABLE")]
        QueueProfilingEnable = 0x2,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE")]
        QueueOnDevice = 0x4,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE_DEFAULT")]
        QueueOnDeviceDefault = 0x8,
        [NativeName("Name", "CL_QUEUE_RESERVED_QCOM")]
        QueueReservedQCom = 0x40000000,
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        QueueThreadLocalExecEnableIntel = 0x80000000,
    }
}
