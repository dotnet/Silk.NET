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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint WaitSemaphoreCount;
/// <summary></summary>
        public Semaphore* PWaitSemaphores;
/// <summary></summary>
        public PipelineStageFlags* PWaitDstStageMask;
/// <summary></summary>
        public uint CommandBufferCount;
/// <summary></summary>
        public CommandBuffer* PCommandBuffers;
/// <summary></summary>
        public uint SignalSemaphoreCount;
/// <summary></summary>
        public Semaphore* PSignalSemaphores;
    }
}
