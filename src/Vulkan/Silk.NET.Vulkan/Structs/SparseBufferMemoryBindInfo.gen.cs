// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct SparseBufferMemoryBindInfo
    {
        public SparseBufferMemoryBindInfo
        (
            Buffer buffer = default,
            uint bindCount = default,
            SparseMemoryBind* pBinds = default
        )
        {
           Buffer = buffer;
           BindCount = bindCount;
           PBinds = pBinds;
        }

/// <summary></summary>
        public Buffer Buffer;
/// <summary></summary>
        public uint BindCount;
/// <summary></summary>
        public SparseMemoryBind* PBinds;
    }
}
