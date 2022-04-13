// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_command_buffer_flags_khr")]
    public enum CommandBufferFlagsKhr : ulong
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_SIMULTANEOUS_USE_KHR")]
        CommandBufferSimultaneousUseKhr = 0x1,
    }
}
