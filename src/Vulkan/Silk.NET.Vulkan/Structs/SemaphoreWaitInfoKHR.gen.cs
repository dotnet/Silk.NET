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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSemaphoreWaitInfoKHR")]
    public unsafe partial struct SemaphoreWaitInfoKHR
    {
        public SemaphoreWaitInfoKHR
        (
            StructureType sType = StructureType.SemaphoreWaitInfo,
            void* pNext = default,
            SemaphoreWaitFlags flags = default,
            uint semaphoreCount = default,
            Semaphore* pSemaphores = default,
            ulong* pValues = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            SemaphoreCount = semaphoreCount;
            PSemaphores = pSemaphores;
            PValues = pValues;
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
        [NativeName("Type", "VkSemaphoreWaitFlags")]
        [NativeName("Type.Name", "VkSemaphoreWaitFlags")]
        [NativeName("Name", "flags")]
        public SemaphoreWaitFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "semaphoreCount")]
        public uint SemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphore*")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "pSemaphores")]
        public Semaphore* PSemaphores;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pValues")]
        public ulong* PValues;
    }
}
