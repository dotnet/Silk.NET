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
    [NativeName("Name", "VkDeviceQueueInfo2")]
    public unsafe struct DeviceQueueInfo2
    {
        public DeviceQueueInfo2
        (
            StructureType sType = StructureType.DeviceQueueInfo2,
            void* pNext = default,
            DeviceQueueCreateFlags flags = default,
            uint queueFamilyIndex = default,
            uint queueIndex = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           QueueFamilyIndex = queueFamilyIndex;
           QueueIndex = queueIndex;
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
        [NativeName("Name", "queueIndex")]
        public uint QueueIndex;
    }
}
