// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_mutable_command_info_khr")]
    public enum MutableCommandInfo : int
    {
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_QUEUE_KHR")]
        CommandCommandQueue = 0x12A0,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_BUFFER_KHR")]
        CommandCommandBuffer = 0x12A1,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_TYPE_KHR")]
        CommandCommandType = 0x12AD,
        [NativeName("Name", "CL_MUTABLE_COMMAND_PROPERTIES_ARRAY_KHR")]
        CommandPropertiesArray = 0x12A2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_KERNEL_KHR")]
        DispatchKernel = 0x12A3,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_DIMENSIONS_KHR")]
        DispatchDimensions = 0x12A4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_OFFSET_KHR")]
        DispatchGlobalWorkOffset = 0x12A5,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_SIZE_KHR")]
        DispatchGlobalWorkSize = 0x12A6,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_WORK_SIZE_KHR")]
        DispatchLocalWorkSize = 0x12A7,
    }
}
