// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_mem_alloc_info_intel")]
    public enum MemAllocInfo : int
    {
        [NativeName("Name", "CL_MEM_ALLOC_TYPE_INTEL")]
        Type = 0x419A,
        [NativeName("Name", "CL_MEM_ALLOC_BASE_PTR_INTEL")]
        BasePtr = 0x419B,
        [NativeName("Name", "CL_MEM_ALLOC_SIZE_INTEL")]
        Size = 0x419C,
        [NativeName("Name", "CL_MEM_ALLOC_DEVICE_INTEL")]
        Device = 0x419D,
        [NativeName("Name", "CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
        BufferLocation = 0x419E,
    }
}
