// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_ext_host_ptr")]
    public unsafe struct MemExtHostPtr
    {
        public MemExtHostPtr
        (
            uint allocationType = default,
            uint hostCachePolicy = default
        )
        {
           AllocationType = allocationType;
           HostCachePolicy = hostCachePolicy;
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
