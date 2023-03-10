// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_command_buffer_structure_type_khr")]
    public enum CommandBufferStructureType : int
    {
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_BASE_CONFIG_KHR")]
        BaseConfig = 0x0,
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_DISPATCH_CONFIG_KHR")]
        DispatchConfig = 0x1,
    }
}
