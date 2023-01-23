// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_mem_cache_type")]
    public enum DeviceMemCacheType : int
    {
        [NativeName("Name", "CL_NONE")]
        None = 0x0,
        [NativeName("Name", "CL_READ_ONLY_CACHE")]
        ReadOnlyCache = 0x1,
        [NativeName("Name", "CL_READ_WRITE_CACHE")]
        ReadWriteCache = 0x2,
    }
}
