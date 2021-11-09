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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBindSparseInfo")]
    public unsafe partial struct BindSparseInfo : IChainStart
    {
        public BindSparseInfo
        (
            StructureType? sType = StructureType.BindSparseInfo,
            void* pNext = null,
            uint? waitSemaphoreCount = null,
            Semaphore* pWaitSemaphores = null,
            uint? bufferBindCount = null,
            SparseBufferMemoryBindInfo* pBufferBinds = null,
            uint? imageOpaqueBindCount = null,
            SparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds = null,
            uint? imageBindCount = null,
            SparseImageMemoryBindInfo* pImageBinds = null,
            uint? signalSemaphoreCount = null,
            Semaphore* pSignalSemaphores = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (waitSemaphoreCount is not null)
            {
                WaitSemaphoreCount = waitSemaphoreCount.Value;
            }

            if (pWaitSemaphores is not null)
            {
                PWaitSemaphores = pWaitSemaphores;
            }

            if (bufferBindCount is not null)
            {
                BufferBindCount = bufferBindCount.Value;
            }

            if (pBufferBinds is not null)
            {
                PBufferBinds = pBufferBinds;
            }

            if (imageOpaqueBindCount is not null)
            {
                ImageOpaqueBindCount = imageOpaqueBindCount.Value;
            }

            if (pImageOpaqueBinds is not null)
            {
                PImageOpaqueBinds = pImageOpaqueBinds;
            }

            if (imageBindCount is not null)
            {
                ImageBindCount = imageBindCount.Value;
            }

            if (pImageBinds is not null)
            {
                PImageBinds = pImageBinds;
            }

            if (signalSemaphoreCount is not null)
            {
                SignalSemaphoreCount = signalSemaphoreCount.Value;
            }

            if (pSignalSemaphores is not null)
            {
                PSignalSemaphores = pSignalSemaphores;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BindSparseInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref BindSparseInfo Chain(
            out BindSparseInfo capture)
        {
            capture = new BindSparseInfo(StructureType.BindSparseInfo);
            return ref capture;
        }
    }
}
