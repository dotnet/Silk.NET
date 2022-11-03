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
    [NativeName("Name", "VkDeviceGroupPresentInfoKHR")]
    public unsafe partial struct DeviceGroupPresentInfoKHR : IExtendsChain<PresentInfoKHR>
    {
        public DeviceGroupPresentInfoKHR
        (
            StructureType? sType = StructureType.DeviceGroupPresentInfoKhr,
            void* pNext = null,
            uint? swapchainCount = null,
            uint* pDeviceMasks = null,
            DeviceGroupPresentModeFlagsKHR? mode = null
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

            if (swapchainCount is not null)
            {
                SwapchainCount = swapchainCount.Value;
            }

            if (pDeviceMasks is not null)
            {
                PDeviceMasks = pDeviceMasks;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
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
        [NativeName("Name", "swapchainCount")]
        public uint SwapchainCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDeviceMasks")]
        public uint* PDeviceMasks;
/// <summary></summary>
        [NativeName("Type", "VkDeviceGroupPresentModeFlagBitsKHR")]
        [NativeName("Type.Name", "VkDeviceGroupPresentModeFlagBitsKHR")]
        [NativeName("Name", "mode")]
        public DeviceGroupPresentModeFlagsKHR Mode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceGroupPresentInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
