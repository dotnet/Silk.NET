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
    [NativeName("Name", "VkDeviceCreateInfo")]
    public unsafe struct DeviceCreateInfo
    {
        public DeviceCreateInfo
        (
            StructureType sType = StructureType.DeviceCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint queueCreateInfoCount = default,
            DeviceQueueCreateInfo* pQueueCreateInfos = default,
            uint enabledLayerCount = default,
            byte** ppEnabledLayerNames = default,
            uint enabledExtensionCount = default,
            byte** ppEnabledExtensionNames = default,
            PhysicalDeviceFeatures* pEnabledFeatures = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           QueueCreateInfoCount = queueCreateInfoCount;
           PQueueCreateInfos = pQueueCreateInfos;
           EnabledLayerCount = enabledLayerCount;
           PpEnabledLayerNames = ppEnabledLayerNames;
           EnabledExtensionCount = enabledExtensionCount;
           PpEnabledExtensionNames = ppEnabledExtensionNames;
           PEnabledFeatures = pEnabledFeatures;
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
    }
}
