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
    [NativeName("Name", "VkAcquireNextImageInfoKHR")]
    public unsafe partial struct AcquireNextImageInfoKHR : IChainable
    {
        public AcquireNextImageInfoKHR
        (
            StructureType? sType = StructureType.AcquireNextImageInfoKhr,
            void* pNext = null,
            SwapchainKHR? swapchain = null,
            ulong? timeout = null,
            Semaphore? semaphore = null,
            Fence? fence = null,
            uint? deviceMask = null
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

            if (swapchain is not null)
            {
                Swapchain = swapchain.Value;
            }

            if (timeout is not null)
            {
                Timeout = timeout.Value;
            }

            if (semaphore is not null)
            {
                Semaphore = semaphore.Value;
            }

            if (fence is not null)
            {
                Fence = fence.Value;
            }

            if (deviceMask is not null)
            {
                DeviceMask = deviceMask.Value;
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
        [NativeName("Type", "VkSwapchainKHR")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "swapchain")]
        public SwapchainKHR Swapchain;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeout")]
        public ulong Timeout;
/// <summary></summary>
        [NativeName("Type", "VkSemaphore")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "semaphore")]
        public Semaphore Semaphore;
/// <summary></summary>
        [NativeName("Type", "VkFence")]
        [NativeName("Type.Name", "VkFence")]
        [NativeName("Name", "fence")]
        public Fence Fence;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMask")]
        public uint DeviceMask;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AcquireNextImageInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
