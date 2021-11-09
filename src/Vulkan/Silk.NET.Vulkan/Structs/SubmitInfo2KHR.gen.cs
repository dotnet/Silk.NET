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
    [NativeName("Name", "VkSubmitInfo2KHR")]
    public unsafe partial struct SubmitInfo2KHR : IChainStart
    {
        public SubmitInfo2KHR
        (
            StructureType? sType = StructureType.SubmitInfo2Khr,
            void* pNext = null,
            SubmitFlagsKHR? flags = null,
            uint? waitSemaphoreInfoCount = null,
            SemaphoreSubmitInfoKHR* pWaitSemaphoreInfos = null,
            uint? commandBufferInfoCount = null,
            CommandBufferSubmitInfoKHR* pCommandBufferInfos = null,
            uint? signalSemaphoreInfoCount = null,
            SemaphoreSubmitInfoKHR* pSignalSemaphoreInfos = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (waitSemaphoreInfoCount is not null)
            {
                WaitSemaphoreInfoCount = waitSemaphoreInfoCount.Value;
            }

            if (pWaitSemaphoreInfos is not null)
            {
                PWaitSemaphoreInfos = pWaitSemaphoreInfos;
            }

            if (commandBufferInfoCount is not null)
            {
                CommandBufferInfoCount = commandBufferInfoCount.Value;
            }

            if (pCommandBufferInfos is not null)
            {
                PCommandBufferInfos = pCommandBufferInfos;
            }

            if (signalSemaphoreInfoCount is not null)
            {
                SignalSemaphoreInfoCount = signalSemaphoreInfoCount.Value;
            }

            if (pSignalSemaphoreInfos is not null)
            {
                PSignalSemaphoreInfos = pSignalSemaphoreInfos;
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
        [NativeName("Type", "VkSubmitFlagsKHR")]
        [NativeName("Type.Name", "VkSubmitFlagsKHR")]
        [NativeName("Name", "flags")]
        public SubmitFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "waitSemaphoreInfoCount")]
        public uint WaitSemaphoreInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphoreSubmitInfoKHR*")]
        [NativeName("Type.Name", "VkSemaphoreSubmitInfoKHR")]
        [NativeName("Name", "pWaitSemaphoreInfos")]
        public SemaphoreSubmitInfoKHR* PWaitSemaphoreInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferInfoCount")]
        public uint CommandBufferInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkCommandBufferSubmitInfoKHR*")]
        [NativeName("Type.Name", "VkCommandBufferSubmitInfoKHR")]
        [NativeName("Name", "pCommandBufferInfos")]
        public CommandBufferSubmitInfoKHR* PCommandBufferInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreInfoCount")]
        public uint SignalSemaphoreInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphoreSubmitInfoKHR*")]
        [NativeName("Type.Name", "VkSemaphoreSubmitInfoKHR")]
        [NativeName("Name", "pSignalSemaphoreInfos")]
        public SemaphoreSubmitInfoKHR* PSignalSemaphoreInfos;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubmitInfo2Khr;
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
        public static unsafe ref SubmitInfo2KHR Chain(
            out SubmitInfo2KHR capture)
        {
            capture = new SubmitInfo2KHR(StructureType.SubmitInfo2Khr);
            return ref capture;
        }
    }
}
