// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
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
        public uint AllocationType;
/// <summary></summary>
        public uint HostCachePolicy;
    }
}
