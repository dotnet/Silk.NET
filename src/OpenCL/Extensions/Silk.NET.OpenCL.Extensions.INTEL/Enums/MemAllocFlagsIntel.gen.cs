// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_mem_alloc_flags_intel")]
    public enum MemAllocFlagsIntel : ulong
    {
        [NativeName("Name", "CL_MEM_ALLOC_WRITE_COMBINED_INTEL")]
        MemAllocWriteCombinedIntel = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_DEVICE_INTEL")]
        MemAllocInitialPlacementDeviceIntel = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_INITIAL_PLACEMENT_HOST_INTEL")]
        MemAllocInitialPlacementHostIntel = 0x4,
    }
}
