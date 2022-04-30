// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_mem_properties_intel")]
    public enum MemProperties : ulong
    {
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_INTEL")]
        AllocFlags = 0x4195,
        [NativeName("Name", "CL_MEM_CHANNEL_INTEL")]
        Channel = 0x4213,
        [NativeName("Name", "CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
        AllocBufferLocation = 0x419E,
    }
}
