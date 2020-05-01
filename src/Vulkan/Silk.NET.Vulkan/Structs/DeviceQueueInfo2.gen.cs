// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DeviceQueueCreateFlags Flags;
/// <summary></summary>
        public uint QueueFamilyIndex;
/// <summary></summary>
        public uint QueueIndex;
    }
}
