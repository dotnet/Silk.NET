// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("clCommandExecutionStatus")]
public enum CommandExecutionStatus : uint
{
    [NativeName("CL_COMPLETE")]
    Complete = 0,

    [NativeName("CL_RUNNING")]
    Running = 1,

    [NativeName("CL_SUBMITTED")]
    Submitted = 2,

    [NativeName("CL_QUEUED")]
    Queued = 3,
}
