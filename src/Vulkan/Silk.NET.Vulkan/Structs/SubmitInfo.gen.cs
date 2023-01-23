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
    [NativeName("Name", "VkSubmitInfo")]
    public unsafe partial struct SubmitInfo : IChainStart
    {
        public SubmitInfo
        (
            StructureType? sType = StructureType.SubmitInfo,
            void* pNext = null,
            uint? waitSemaphoreCount = null,
            Semaphore* pWaitSemaphores = null,
            PipelineStageFlags* pWaitDstStageMask = null,
            uint? commandBufferCount = null,
            CommandBuffer* pCommandBuffers = null,
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

            if (pWaitDstStageMask is not null)
            {
                PWaitDstStageMask = pWaitDstStageMask;
            }

            if (commandBufferCount is not null)
            {
                CommandBufferCount = commandBufferCount.Value;
            }

            if (pCommandBuffers is not null)
            {
                PCommandBuffers = pCommandBuffers;
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
        [NativeName("Type", "VkPipelineStageFlags*")]
        [NativeName("Type.Name", "VkPipelineStageFlags")]
        [NativeName("Name", "pWaitDstStageMask")]
        public PipelineStageFlags* PWaitDstStageMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferCount")]
        public uint CommandBufferCount;
/// <summary></summary>
        [NativeName("Type", "VkCommandBuffer*")]
        [NativeName("Type.Name", "VkCommandBuffer")]
        [NativeName("Name", "pCommandBuffers")]
        public CommandBuffer* PCommandBuffers;
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
            return SType = StructureType.SubmitInfo;
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
        public static unsafe ref SubmitInfo Chain(
            out SubmitInfo capture)
        {
            capture = new SubmitInfo(StructureType.SubmitInfo);
            return ref capture;
        }
    }
}
