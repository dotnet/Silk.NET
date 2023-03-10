// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Flags]
    [NativeName("Name", "cl_command_termination_reason_arm")]
    public enum CommandTerminationReason : int
    {
        [NativeName("Name", "CL_COMMAND_TERMINATION_COMPLETION_ARM")]
        Completion = 0x0,
        [NativeName("Name", "CL_COMMAND_TERMINATION_CONTROLLED_SUCCESS_ARM")]
        ControlledSuccess = 0x1,
        [NativeName("Name", "CL_COMMAND_TERMINATION_CONTROLLED_FAILURE_ARM")]
        ControlledFailure = 0x2,
        [NativeName("Name", "CL_COMMAND_TERMINATION_ERROR_ARM")]
        Error = 0x3,
    }
}
