// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [NativeName("Name", "cl_mem_properties")]
    public enum MemProperties : int
    {
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        MemAllocFlags = 0x40D7,
        [NativeName("Name", "CL_DEVICE_HANDLE_LIST_KHR")]
        DeviceHandleListKhr = 0x2051,
    }
}
