// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_platform_command_buffer_capabilities_khr ")]
    public enum PlatformCommandBufferCapabilities : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_UNIVERSAL_SYNC_KHR")]
        UniversalSync = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_REMAP_QUEUES_KHR")]
        RemapQueues = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_AUTOMATIC_REMAP_KHR")]
        AutomaticRemap = 0x4,
    }
}
