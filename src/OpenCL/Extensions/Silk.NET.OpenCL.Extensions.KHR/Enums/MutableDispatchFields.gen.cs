// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_mutable_dispatch_fields_khr")]
    public enum MutableDispatchFields : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_OFFSET_KHR")]
        GlobalOffset = 0x1,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_SIZE_KHR")]
        GlobalSize = 0x2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_SIZE_KHR")]
        LocalSize = 0x4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_ARGUMENTS_KHR")]
        Arguments = 0x8,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_EXEC_INFO_KHR")]
        ExecInfo = 0x10,
    }
}
