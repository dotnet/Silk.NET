// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceQueueCreateInfo")]
    public unsafe partial struct DeviceQueueCreateInfo
    {
        public DeviceQueueCreateInfo
        (
            StructureType sType = StructureType.DeviceQueueCreateInfo,
            void* pNext = default,
            DeviceQueueCreateFlags flags = default,
            uint queueFamilyIndex = default,
            uint queueCount = default,
            float* pQueuePriorities = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            QueueFamilyIndex = queueFamilyIndex;
            QueueCount = queueCount;
            PQueuePriorities = pQueuePriorities;
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
        [NativeName("Type", "VkDeviceQueueCreateFlags")]
        [NativeName("Type.Name", "VkDeviceQueueCreateFlags")]
        [NativeName("Name", "flags")]
        public DeviceQueueCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueCount")]
        public uint QueueCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pQueuePriorities")]
        public float* PQueuePriorities;
    }
}
