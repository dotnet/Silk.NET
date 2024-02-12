// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_command_buffer_state_khr")]
    public enum CommandBufferState : int
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_RECORDING_KHR")]
        Recording = 0x0,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_EXECUTABLE_KHR")]
        Executable = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_PENDING_KHR")]
        Pending = 0x2,
    }
}
