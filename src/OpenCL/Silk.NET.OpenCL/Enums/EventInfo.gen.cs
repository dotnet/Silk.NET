// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_event_info")]
    public enum EventInfo : int
    {
        [NativeName("Name", "CL_EVENT_COMMAND_QUEUE")]
        CommandQueue = 0x11D0,
        [NativeName("Name", "CL_EVENT_COMMAND_TYPE")]
        CommandType = 0x11D1,
        [NativeName("Name", "CL_EVENT_REFERENCE_COUNT")]
        ReferenceCount = 0x11D2,
        [NativeName("Name", "CL_EVENT_COMMAND_EXECUTION_STATUS")]
        CommandExecutionStatus = 0x11D3,
        [NativeName("Name", "CL_EVENT_CONTEXT")]
        Context = 0x11D4,
        [NativeName("Name", "CL_EVENT_COMMAND_TERMINATION_REASON_ARM")]
        CommandTerminationReasonArm = 0x41ED,
    }
}
