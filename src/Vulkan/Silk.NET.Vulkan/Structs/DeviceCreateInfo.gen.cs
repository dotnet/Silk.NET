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
    [NativeName("Name", "VkDeviceCreateInfo")]
    public unsafe partial struct DeviceCreateInfo : IChainStart
    {
        public DeviceCreateInfo
        (
            StructureType? sType = StructureType.DeviceCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? queueCreateInfoCount = null,
            DeviceQueueCreateInfo* pQueueCreateInfos = null,
            uint? enabledLayerCount = null,
            byte** ppEnabledLayerNames = null,
            uint? enabledExtensionCount = null,
            byte** ppEnabledExtensionNames = null,
            PhysicalDeviceFeatures* pEnabledFeatures = null
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

            if (queueCreateInfoCount is not null)
            {
                QueueCreateInfoCount = queueCreateInfoCount.Value;
            }

            if (pQueueCreateInfos is not null)
            {
                PQueueCreateInfos = pQueueCreateInfos;
            }

            if (enabledLayerCount is not null)
            {
                EnabledLayerCount = enabledLayerCount.Value;
            }

            if (ppEnabledLayerNames is not null)
            {
                PpEnabledLayerNames = ppEnabledLayerNames;
            }

            if (enabledExtensionCount is not null)
            {
                EnabledExtensionCount = enabledExtensionCount.Value;
            }

            if (ppEnabledExtensionNames is not null)
            {
                PpEnabledExtensionNames = ppEnabledExtensionNames;
            }

            if (pEnabledFeatures is not null)
            {
                PEnabledFeatures = pEnabledFeatures;
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
        [NativeName("Type", "VkDeviceCreateFlags")]
        [NativeName("Type.Name", "VkDeviceCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueCreateInfoCount")]
        public uint QueueCreateInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceQueueCreateInfo*")]
        [NativeName("Type.Name", "VkDeviceQueueCreateInfo")]
        [NativeName("Name", "pQueueCreateInfos")]
        public DeviceQueueCreateInfo* PQueueCreateInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledLayerCount")]
        public uint EnabledLayerCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "ppEnabledLayerNames")]
        public byte** PpEnabledLayerNames;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledExtensionCount")]
        public uint EnabledExtensionCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "ppEnabledExtensionNames")]
        public byte** PpEnabledExtensionNames;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceFeatures*")]
        [NativeName("Type.Name", "VkPhysicalDeviceFeatures")]
        [NativeName("Name", "pEnabledFeatures")]
        public PhysicalDeviceFeatures* PEnabledFeatures;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DeviceCreateInfo;
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
        public static unsafe ref DeviceCreateInfo Chain(
            out DeviceCreateInfo capture)
        {
            capture = new DeviceCreateInfo(StructureType.DeviceCreateInfo);
            return ref capture;
        }
    }
}
