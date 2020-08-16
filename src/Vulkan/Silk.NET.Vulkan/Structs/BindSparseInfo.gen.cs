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
    [NativeName("Name", "VkBindSparseInfo")]
    public unsafe partial struct BindSparseInfo
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "waitSemaphoreCount")]
        public uint WaitSemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphore*")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "pWaitSemaphores")]
        public Semaphore* PWaitSemaphores;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferBindCount")]
        public uint BufferBindCount;
/// <summary></summary>
        [NativeName("Type", "VkSparseBufferMemoryBindInfo*")]
        [NativeName("Type.Name", "VkSparseBufferMemoryBindInfo")]
        [NativeName("Name", "pBufferBinds")]
        public SparseBufferMemoryBindInfo* PBufferBinds;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageOpaqueBindCount")]
        public uint ImageOpaqueBindCount;
/// <summary></summary>
        [NativeName("Type", "VkSparseImageOpaqueMemoryBindInfo*")]
        [NativeName("Type.Name", "VkSparseImageOpaqueMemoryBindInfo")]
        [NativeName("Name", "pImageOpaqueBinds")]
        public SparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageBindCount")]
        public uint ImageBindCount;
/// <summary></summary>
        [NativeName("Type", "VkSparseImageMemoryBindInfo*")]
        [NativeName("Type.Name", "VkSparseImageMemoryBindInfo")]
        [NativeName("Name", "pImageBinds")]
        public SparseImageMemoryBindInfo* PImageBinds;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreCount")]
        public uint SignalSemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphore*")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "pSignalSemaphores")]
        public Semaphore* PSignalSemaphores;
    }
}
