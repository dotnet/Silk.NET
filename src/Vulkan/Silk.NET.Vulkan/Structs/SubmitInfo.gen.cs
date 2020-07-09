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
    [NativeName("Name", "VkSubmitInfo")]
    public unsafe struct SubmitInfo
    {
        public SubmitInfo
        (
            StructureType sType = StructureType.SubmitInfo,
            void* pNext = default,
            uint waitSemaphoreCount = default,
            Semaphore* pWaitSemaphores = default,
            PipelineStageFlags* pWaitDstStageMask = default,
            uint commandBufferCount = default,
            CommandBuffer* pCommandBuffers = default,
            uint signalSemaphoreCount = default,
            Semaphore* pSignalSemaphores = default
        )
        {
           SType = sType;
           PNext = pNext;
           WaitSemaphoreCount = waitSemaphoreCount;
           PWaitSemaphores = pWaitSemaphores;
           PWaitDstStageMask = pWaitDstStageMask;
           CommandBufferCount = commandBufferCount;
           PCommandBuffers = pCommandBuffers;
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
    }
}
