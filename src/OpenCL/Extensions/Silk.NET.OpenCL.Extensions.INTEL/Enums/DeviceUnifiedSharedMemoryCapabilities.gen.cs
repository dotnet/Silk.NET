// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_device_unified_shared_memory_capabilities_intel")]
    public enum DeviceUnifiedSharedMemoryCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ACCESS_INTEL")]
        Access = 0x1,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_ATOMIC_ACCESS_INTEL")]
        AtomicAccess = 0x2,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ACCESS_INTEL")]
        ConcurrentAccess = 0x4,
        [NativeName("Name", "CL_UNIFIED_SHARED_MEMORY_CONCURRENT_ATOMIC_ACCESS_INTEL")]
        ConcurrentAtomicAccess = 0x8,
    }
}
