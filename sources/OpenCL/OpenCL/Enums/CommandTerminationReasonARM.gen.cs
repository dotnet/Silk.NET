// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_termination_reason_arm")]
public enum CommandTerminationReasonARM : uint
{
    [NativeName("CL_COMMAND_TERMINATION_COMPLETION_ARM")]
    Completion = 0,

    [NativeName("CL_COMMAND_TERMINATION_CONTROLLED_SUCCESS_ARM")]
    ControlledSuccess = 1,

    [NativeName("CL_COMMAND_TERMINATION_CONTROLLED_FAILURE_ARM")]
    ControlledFailure = 2,

    [NativeName("CL_COMMAND_TERMINATION_ERROR_ARM")]
    Error = 3,
}
