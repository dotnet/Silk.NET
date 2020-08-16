// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAcquireProfilingLockInfoKHR")]
    public unsafe partial struct AcquireProfilingLockInfoKHR
    {
        public AcquireProfilingLockInfoKHR
        (
            StructureType sType = StructureType.AcquireProfilingLockInfoKhr,
            void* pNext = default,
            AcquireProfilingLockFlagsKHR flags = default,
            ulong timeout = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Timeout = timeout;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkAcquireProfilingLockFlagsKHR")]
        [NativeName("Type.Name", "VkAcquireProfilingLockFlagsKHR")]
        [NativeName("Name", "flags")]
        public AcquireProfilingLockFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeout")]
        public ulong Timeout;
    }
}
