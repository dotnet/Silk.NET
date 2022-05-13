// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "cl_mem_ext_host_ptr")]
    public unsafe partial struct MemExtHostPtr
    {
        public MemExtHostPtr
        (
            uint? allocationType = null,
            uint? hostCachePolicy = null
        ) : this()
        {
            if (allocationType is not null)
            {
                AllocationType = allocationType.Value;
            }

            if (hostCachePolicy is not null)
            {
                HostCachePolicy = hostCachePolicy.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "allocation_type")]
        public uint AllocationType;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "host_cache_policy")]
        public uint HostCachePolicy;
    }
}
