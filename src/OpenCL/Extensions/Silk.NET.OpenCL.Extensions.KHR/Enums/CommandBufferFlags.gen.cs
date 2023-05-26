// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_command_buffer_flags_khr")]
    public enum CommandBufferFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_COMMAND_BUFFER_SIMULTANEOUS_USE_KHR")]
        SimultaneousUse = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_MUTABLE_KHR")]
        Mutable = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_DEVICE_SIDE_SYNC_KHR")]
        DeviceSideSync = 0x4,
    }
}
