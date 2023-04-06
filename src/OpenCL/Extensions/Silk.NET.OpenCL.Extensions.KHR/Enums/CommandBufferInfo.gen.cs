// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_command_buffer_info_khr")]
    public enum CommandBufferInfo : int
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_QUEUES_KHR")]
        Queues = 0x1294,
        [NativeName("Name", "CL_COMMAND_BUFFER_NUM_QUEUES_KHR")]
        NumQueues = 0x1295,
        [NativeName("Name", "CL_COMMAND_BUFFER_REFERENCE_COUNT_KHR")]
        ReferenceCount = 0x1296,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_KHR")]
        State = 0x1297,
        [NativeName("Name", "CL_COMMAND_BUFFER_PROPERTIES_ARRAY_KHR")]
        PropertiesArray = 0x1298,
        [NativeName("Name", "CL_COMMAND_BUFFER_CONTEXT_KHR")]
        Context = 0x1299,
    }
}
