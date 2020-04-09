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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint QueueCreateInfoCount;
/// <summary></summary>
        public DeviceQueueCreateInfo* PQueueCreateInfos;
/// <summary></summary>
        public uint EnabledLayerCount;
/// <summary></summary>
        public byte** PpEnabledLayerNames;
/// <summary></summary>
        public uint EnabledExtensionCount;
/// <summary></summary>
        public byte** PpEnabledExtensionNames;
/// <summary></summary>
        public PhysicalDeviceFeatures* PEnabledFeatures;
    }
}
