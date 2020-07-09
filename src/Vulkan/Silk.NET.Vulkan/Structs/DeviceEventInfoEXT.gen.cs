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
    [NativeName("Name", "VkDeviceEventInfoEXT")]
    public unsafe struct DeviceEventInfoEXT
    {
        public DeviceEventInfoEXT
        (
            StructureType sType = StructureType.DeviceEventInfoExt,
            void* pNext = default,
            DeviceEventTypeEXT deviceEvent = default
        )
        {
           SType = sType;
           PNext = pNext;
           DeviceEvent = deviceEvent;
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
        [NativeName("Type", "VkDeviceEventTypeEXT")]
        [NativeName("Type.Name", "VkDeviceEventTypeEXT")]
        [NativeName("Name", "deviceEvent")]
        public DeviceEventTypeEXT DeviceEvent;
    }
}
