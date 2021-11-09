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
    [NativeName("Name", "VkDeviceGroupSwapchainCreateInfoKHR")]
    public unsafe partial struct DeviceGroupSwapchainCreateInfoKHR : IExtendsChain<SwapchainCreateInfoKHR>
    {
        public DeviceGroupSwapchainCreateInfoKHR
        (
            StructureType? sType = StructureType.DeviceGroupSwapchainCreateInfoKhr,
            void* pNext = null,
            DeviceGroupPresentModeFlagsKHR? modes = null
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

            if (modes is not null)
            {
                Modes = modes.Value;
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
        [NativeName("Type", "VkDeviceGroupPresentModeFlagsKHR")]
        [NativeName("Type.Name", "VkDeviceGroupPresentModeFlagsKHR")]
        [NativeName("Name", "modes")]
        public DeviceGroupPresentModeFlagsKHR Modes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceGroupSwapchainCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
