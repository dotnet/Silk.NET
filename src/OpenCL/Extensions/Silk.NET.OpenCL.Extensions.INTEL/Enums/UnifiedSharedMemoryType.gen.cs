// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_unified_shared_memory_type_intel")]
    public enum UnifiedSharedMemoryType : int
    {
        [NativeName("Name", "CL_MEM_TYPE_UNKNOWN_INTEL")]
        Unknown = 0x4196,
        [NativeName("Name", "CL_MEM_TYPE_HOST_INTEL")]
        Host = 0x4197,
        [NativeName("Name", "CL_MEM_TYPE_DEVICE_INTEL")]
        Device = 0x4198,
        [NativeName("Name", "CL_MEM_TYPE_SHARED_INTEL")]
        Shared = 0x4199,
    }
}
