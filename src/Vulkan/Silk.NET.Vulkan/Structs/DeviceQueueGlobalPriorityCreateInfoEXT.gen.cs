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
    public unsafe struct DeviceQueueGlobalPriorityCreateInfoEXT
    {
        public DeviceQueueGlobalPriorityCreateInfoEXT
        (
            StructureType sType = StructureType.DeviceQueueGlobalPriorityCreateInfoExt,
            void* pNext = default,
            QueueGlobalPriorityEXT globalPriority = default
        )
        {
           SType = sType;
           PNext = pNext;
           GlobalPriority = globalPriority;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public QueueGlobalPriorityEXT GlobalPriority;
    }
}
