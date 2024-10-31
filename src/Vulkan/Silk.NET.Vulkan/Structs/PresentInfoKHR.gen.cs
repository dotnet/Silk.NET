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
    [NativeName("Name", "VkPresentInfoKHR")]
    public unsafe partial struct PresentInfoKHR : IChainStart
    {
        public PresentInfoKHR
        (
            StructureType? sType = StructureType.PresentInfoKhr,
            void* pNext = null,
            uint? waitSemaphoreCount = null,
            Semaphore* pWaitSemaphores = null,
            uint? swapchainCount = null,
            SwapchainKHR* pSwapchains = null,
            uint* pImageIndices = null,
            Result* pResults = null
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

            if (swapchainCount is not null)
            {
                SwapchainCount = swapchainCount.Value;
            }

            if (pSwapchains is not null)
            {
                PSwapchains = pSwapchains;
            }

            if (pImageIndices is not null)
            {
                PImageIndices = pImageIndices;
            }

            if (pResults is not null)
            {
                PResults = pResults;
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
        [NativeName("Name", "swapchainCount")]
        public uint SwapchainCount;
/// <summary></summary>
        [NativeName("Type", "VkSwapchainKHR*")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "pSwapchains")]
        public SwapchainKHR* PSwapchains;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pImageIndices")]
        public uint* PImageIndices;
/// <summary></summary>
        [NativeName("Type", "VkResult*")]
        [NativeName("Type.Name", "VkResult")]
        [NativeName("Name", "pResults")]
        public Result* PResults;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PresentInfoKhr;
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
        public static unsafe ref PresentInfoKHR Chain(
            out PresentInfoKHR capture)
        {
            capture = new PresentInfoKHR(StructureType.PresentInfoKhr);
            return ref capture;
        }
    }
}
