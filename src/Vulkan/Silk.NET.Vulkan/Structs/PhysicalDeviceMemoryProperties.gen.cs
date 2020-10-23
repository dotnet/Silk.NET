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
    [NativeName("Name", "VkPhysicalDeviceMemoryProperties")]
    public unsafe partial struct PhysicalDeviceMemoryProperties
    {
        public PhysicalDeviceMemoryProperties
        (
            uint? memoryTypeCount = null,
            uint? memoryHeapCount = null
        )
        {
            fixed (PhysicalDeviceMemoryProperties* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (memoryTypeCount is not null)
            {
                MemoryTypeCount = memoryTypeCount.Value;
            }

            if (memoryHeapCount is not null)
            {
                MemoryHeapCount = memoryHeapCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeCount")]
        public uint MemoryTypeCount;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_0;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_1;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_2;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_3;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_4;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_5;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_6;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_7;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_8;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_9;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_10;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_11;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_12;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_13;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_14;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_15;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_16;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_17;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_18;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_19;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_20;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_21;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_22;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_23;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_24;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_25;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_26;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_27;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_28;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_29;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_30;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryType")]
        [NativeName("Type.Name", "VkMemoryType")]
        [NativeName("Name", "memoryTypes")]
        public MemoryType MemoryTypes_31;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryHeapCount")]
        public uint MemoryHeapCount;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_0;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_1;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_2;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_3;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_4;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_5;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_6;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_7;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_8;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_9;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_10;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_11;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_12;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_13;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_14;
        /// <summary></summary>
        [NativeName("Type", "VkMemoryHeap")]
        [NativeName("Type.Name", "VkMemoryHeap")]
        [NativeName("Name", "memoryHeaps")]
        public MemoryHeap MemoryHeaps_15;
    }
}
