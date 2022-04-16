// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_command_queue_info")]
    public enum CommandQueueInfo : int
    {
        [NativeName("Name", "CL_QUEUE_CONTEXT")]
        Context = 0x1090,
        [NativeName("Name", "CL_QUEUE_DEVICE")]
        Device = 0x1091,
        [NativeName("Name", "CL_QUEUE_REFERENCE_COUNT")]
        ReferenceCount = 0x1092,
        [NativeName("Name", "CL_QUEUE_PROPERTIES")]
        Properties = 0x1093,
        [NativeName("Name", "CL_QUEUE_SIZE")]
        Size = 0x1094,
        [NativeName("Name", "CL_QUEUE_DEVICE_DEFAULT")]
        DeviceDefault = 0x1095,
        [NativeName("Name", "CL_QUEUE_PROPERTIES_ARRAY")]
        PropertiesArray = 0x1098,
    }
}
