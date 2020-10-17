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
    [NativeName("Name", "VkDeviceGroupBindSparseInfo")]
    public unsafe partial struct DeviceGroupBindSparseInfo
    {
        public DeviceGroupBindSparseInfo
        (
            StructureType sType = StructureType.DeviceGroupBindSparseInfo,
            void* pNext = default,
            uint resourceDeviceIndex = default,
            uint memoryDeviceIndex = default
        )
        {
            SType = sType;
            PNext = pNext;
            ResourceDeviceIndex = resourceDeviceIndex;
            MemoryDeviceIndex = memoryDeviceIndex;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resourceDeviceIndex")]
        public uint ResourceDeviceIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryDeviceIndex")]
        public uint MemoryDeviceIndex;
    }
}
