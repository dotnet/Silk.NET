// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceMemoryReportCallbackDataEXT")]
    public unsafe partial struct DeviceMemoryReportCallbackDataEXT
    {
        public DeviceMemoryReportCallbackDataEXT
        (
            StructureType? sType = StructureType.DeviceMemoryReportCallbackDataExt,
            void* pNext = null,
            uint? flags = null,
            DeviceMemoryReportEventTypeEXT? type = null,
            ulong? memoryObjectId = null,
            ulong? size = null,
            ObjectType? objectType = null,
            ulong? objectHandle = null,
            uint? heapIndex = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (memoryObjectId is not null)
            {
                MemoryObjectId = memoryObjectId.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (objectType is not null)
            {
                ObjectType = objectType.Value;
            }

            if (objectHandle is not null)
            {
                ObjectHandle = objectHandle.Value;
            }

            if (heapIndex is not null)
            {
                HeapIndex = heapIndex.Value;
            }
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
        [NativeName("Type", "VkDeviceMemoryReportFlagsEXT")]
        [NativeName("Type.Name", "VkDeviceMemoryReportFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemoryReportEventTypeEXT")]
        [NativeName("Type.Name", "VkDeviceMemoryReportEventTypeEXT")]
        [NativeName("Name", "type")]
        public DeviceMemoryReportEventTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "memoryObjectId")]
        public ulong MemoryObjectId;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkObjectType")]
        [NativeName("Type.Name", "VkObjectType")]
        [NativeName("Name", "objectType")]
        public ObjectType ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "objectHandle")]
        public ulong ObjectHandle;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "heapIndex")]
        public uint HeapIndex;
    }
}
