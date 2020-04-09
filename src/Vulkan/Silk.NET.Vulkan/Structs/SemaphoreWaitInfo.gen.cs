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
    public unsafe struct SemaphoreWaitInfo
    {
        public SemaphoreWaitInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SemaphoreWaitFlags Flags;
/// <summary></summary>
        public uint SemaphoreCount;
/// <summary></summary>
        public Semaphore* PSemaphores;
/// <summary></summary>
        public ulong* PValues;
    }
}
