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
    public unsafe struct DeviceQueueCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DeviceQueueCreateFlags Flags;
/// <summary></summary>
        public uint QueueFamilyIndex;
/// <summary></summary>
        public uint QueueCount;
/// <summary></summary>
        public float* PQueuePriorities;
    }
}
