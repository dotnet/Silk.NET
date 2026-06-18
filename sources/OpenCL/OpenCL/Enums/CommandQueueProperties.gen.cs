// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_queue_properties")]
[Flags]
public enum CommandQueueProperties : ulong
{
    None = 0x0,

    [NativeName("CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
    OutOfOrderExecModeEnable = 0x1,

    [NativeName("CL_QUEUE_PROFILING_ENABLE")]
    ProfilingEnable = 0x2,

    [NativeName("CL_QUEUE_ON_DEVICE")]
    OnDevice = 0x4,

    [NativeName("CL_QUEUE_ON_DEVICE_DEFAULT")]
    OnDeviceDefault = 0x8,

    [NativeName("CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
    ThreadLocalExecEnableINTEL = 0x80000000,

    [NativeName("CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
    NoSyncOperationsINTEL = 0x20000000,
}
