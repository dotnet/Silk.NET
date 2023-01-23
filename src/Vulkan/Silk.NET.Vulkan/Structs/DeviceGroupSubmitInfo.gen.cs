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
    [NativeName("Name", "VkDeviceGroupSubmitInfo")]
    [NativeName("Aliases", "VkDeviceGroupSubmitInfoKHR")]
    public unsafe partial struct DeviceGroupSubmitInfo : IExtendsChain<SubmitInfo>
    {
        public DeviceGroupSubmitInfo
        (
            StructureType? sType = StructureType.DeviceGroupSubmitInfo,
            void* pNext = null,
            uint? waitSemaphoreCount = null,
            uint* pWaitSemaphoreDeviceIndices = null,
            uint? commandBufferCount = null,
            uint* pCommandBufferDeviceMasks = null,
            uint? signalSemaphoreCount = null,
            uint* pSignalSemaphoreDeviceIndices = null
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

            if (pWaitSemaphoreDeviceIndices is not null)
            {
                PWaitSemaphoreDeviceIndices = pWaitSemaphoreDeviceIndices;
            }

            if (commandBufferCount is not null)
            {
                CommandBufferCount = commandBufferCount.Value;
            }

            if (pCommandBufferDeviceMasks is not null)
            {
                PCommandBufferDeviceMasks = pCommandBufferDeviceMasks;
            }

            if (signalSemaphoreCount is not null)
            {
                SignalSemaphoreCount = signalSemaphoreCount.Value;
            }

            if (pSignalSemaphoreDeviceIndices is not null)
            {
                PSignalSemaphoreDeviceIndices = pSignalSemaphoreDeviceIndices;
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
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pWaitSemaphoreDeviceIndices")]
        public uint* PWaitSemaphoreDeviceIndices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferCount")]
        public uint CommandBufferCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCommandBufferDeviceMasks")]
        public uint* PCommandBufferDeviceMasks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreCount")]
        public uint SignalSemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pSignalSemaphoreDeviceIndices")]
        public uint* PSignalSemaphoreDeviceIndices;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceGroupSubmitInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
