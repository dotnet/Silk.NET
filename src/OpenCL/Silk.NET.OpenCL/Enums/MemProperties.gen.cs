// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_properties")]
    public enum MemProperties : ulong
    {
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        AllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_MEM_DEVICE_HANDLE_LIST_KHR")]
        DeviceHandleListKhr = 0x2051,
        [NativeName("Name", "CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
        LocallyUncachedResourceIntel = 0x4218,
        [NativeName("Name", "CL_MEM_DEVICE_ID_INTEL")]
        DeviceIDIntel = 0x4219,
    }
}
