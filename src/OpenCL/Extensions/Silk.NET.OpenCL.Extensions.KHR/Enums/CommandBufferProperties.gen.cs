// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_command_buffer_properties_khr")]
    public enum CommandBufferProperties : ulong
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_FLAGS_KHR")]
        Flags = 0x1293,
        [NativeName("Name", "CL_COMMAND_BUFFER_MUTABLE_DISPATCH_ASSERTS_KHR")]
        MutableDispatchAsserts = 0x12B7,
    }
}
