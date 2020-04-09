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
    public unsafe struct PhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public PhysicalDeviceImageDrmFormatModifierInfoEXT
        (
            StructureType sType = StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt,
            void* pNext = default,
            ulong drmFormatModifier = default,
            SharingMode sharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           DrmFormatModifier = drmFormatModifier;
           SharingMode = sharingMode;
           QueueFamilyIndexCount = queueFamilyIndexCount;
           PQueueFamilyIndices = pQueueFamilyIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong DrmFormatModifier;
/// <summary></summary>
        public SharingMode SharingMode;
/// <summary></summary>
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        public uint* PQueueFamilyIndices;
    }
}
