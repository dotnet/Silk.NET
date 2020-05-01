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

namespace Silk.NET.Vulkan
{
    public unsafe struct BindSparseInfo
    {
        public BindSparseInfo
        (
            StructureType sType = StructureType.BindSparseInfo,
            void* pNext = default,
            uint waitSemaphoreCount = default,
            Semaphore* pWaitSemaphores = default,
            uint bufferBindCount = default,
            SparseBufferMemoryBindInfo* pBufferBinds = default,
            uint imageOpaqueBindCount = default,
            SparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds = default,
            uint imageBindCount = default,
            SparseImageMemoryBindInfo* pImageBinds = default,
            uint signalSemaphoreCount = default,
            Semaphore* pSignalSemaphores = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreCount = waitSemaphoreCount;
           PWaitSemaphores = pWaitSemaphores;
           BufferBindCount = bufferBindCount;
           PBufferBinds = pBufferBinds;
           ImageOpaqueBindCount = imageOpaqueBindCount;
           PImageOpaqueBinds = pImageOpaqueBinds;
           ImageBindCount = imageBindCount;
           PImageBinds = pImageBinds;
           SignalSemaphoreCount = signalSemaphoreCount;
           PSignalSemaphores = pSignalSemaphores;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreCount;
/// <summary></summary>
        public Semaphore* PWaitSemaphores;
/// <summary></summary>
        public uint BufferBindCount;
/// <summary></summary>
        public SparseBufferMemoryBindInfo* PBufferBinds;
/// <summary></summary>
        public uint ImageOpaqueBindCount;
/// <summary></summary>
        public SparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;
/// <summary></summary>
        public uint ImageBindCount;
/// <summary></summary>
        public SparseImageMemoryBindInfo* PImageBinds;
/// <summary></summary>
        public uint SignalSemaphoreCount;
/// <summary></summary>
        public Semaphore* PSignalSemaphores;
    }
}
