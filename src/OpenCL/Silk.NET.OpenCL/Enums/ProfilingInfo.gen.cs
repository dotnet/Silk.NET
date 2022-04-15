// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_profiling_info")]
    public enum ProfilingInfo : int
    {
        [NativeName("Name", "CL_PROFILING_COMMAND_QUEUED")]
        ProfilingCommandQueued = 0x1280,
        [NativeName("Name", "CL_PROFILING_COMMAND_SUBMIT")]
        ProfilingCommandSubmit = 0x1281,
        [NativeName("Name", "CL_PROFILING_COMMAND_START")]
        ProfilingCommandStart = 0x1282,
        [NativeName("Name", "CL_PROFILING_COMMAND_END")]
        ProfilingCommandEnd = 0x1283,
        [NativeName("Name", "CL_PROFILING_COMMAND_COMPLETE")]
        ProfilingCommandComplete = 0x1284,
    }
}
