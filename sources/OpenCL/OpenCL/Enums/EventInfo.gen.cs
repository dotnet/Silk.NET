// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_event_info")]
public enum EventInfo : uint
{
    [NativeName("CL_EVENT_COMMAND_QUEUE")]
    CommandQueue = 4560,

    [NativeName("CL_EVENT_COMMAND_TYPE")]
    CommandType = 4561,

    [NativeName("CL_EVENT_REFERENCE_COUNT")]
    ReferenceCount = 4562,

    [NativeName("CL_EVENT_COMMAND_EXECUTION_STATUS")]
    CommandExecutionStatus = 4563,

    [NativeName("CL_EVENT_CONTEXT")]
    Context = 4564,

    [NativeName("CL_EVENT_COMMAND_TERMINATION_REASON_ARM")]
    CommandTerminationReasonARM = 16877,
}
