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
    public unsafe struct PhysicalDeviceMemoryProperties
    {
        public PhysicalDeviceMemoryProperties
        (
            uint memoryTypeCount = default,
            uint memoryHeapCount = default
        )
        {
           MemoryTypeCount = memoryTypeCount;
           MemoryTypes_0 = default;
           MemoryTypes_1 = default;
           MemoryTypes_2 = default;
           MemoryTypes_3 = default;
           MemoryTypes_4 = default;
           MemoryTypes_5 = default;
           MemoryTypes_6 = default;
           MemoryTypes_7 = default;
           MemoryTypes_8 = default;
           MemoryTypes_9 = default;
           MemoryTypes_10 = default;
           MemoryTypes_11 = default;
           MemoryTypes_12 = default;
           MemoryTypes_13 = default;
           MemoryTypes_14 = default;
           MemoryTypes_15 = default;
           MemoryTypes_16 = default;
           MemoryTypes_17 = default;
           MemoryTypes_18 = default;
           MemoryTypes_19 = default;
           MemoryTypes_20 = default;
           MemoryTypes_21 = default;
           MemoryTypes_22 = default;
           MemoryTypes_23 = default;
           MemoryTypes_24 = default;
           MemoryTypes_25 = default;
           MemoryTypes_26 = default;
           MemoryTypes_27 = default;
           MemoryTypes_28 = default;
           MemoryTypes_29 = default;
           MemoryTypes_30 = default;
           MemoryTypes_31 = default;
           MemoryHeapCount = memoryHeapCount;
           MemoryHeaps_0 = default;
           MemoryHeaps_1 = default;
           MemoryHeaps_2 = default;
           MemoryHeaps_3 = default;
           MemoryHeaps_4 = default;
           MemoryHeaps_5 = default;
           MemoryHeaps_6 = default;
           MemoryHeaps_7 = default;
           MemoryHeaps_8 = default;
           MemoryHeaps_9 = default;
           MemoryHeaps_10 = default;
           MemoryHeaps_11 = default;
           MemoryHeaps_12 = default;
           MemoryHeaps_13 = default;
           MemoryHeaps_14 = default;
           MemoryHeaps_15 = default;
        }

/// <summary></summary>
        public uint MemoryTypeCount;
        /// <summary></summary>
        public MemoryType MemoryTypes_0;
        /// <summary></summary>
        public MemoryType MemoryTypes_1;
        /// <summary></summary>
        public MemoryType MemoryTypes_2;
        /// <summary></summary>
        public MemoryType MemoryTypes_3;
        /// <summary></summary>
        public MemoryType MemoryTypes_4;
        /// <summary></summary>
        public MemoryType MemoryTypes_5;
        /// <summary></summary>
        public MemoryType MemoryTypes_6;
        /// <summary></summary>
        public MemoryType MemoryTypes_7;
        /// <summary></summary>
        public MemoryType MemoryTypes_8;
        /// <summary></summary>
        public MemoryType MemoryTypes_9;
        /// <summary></summary>
        public MemoryType MemoryTypes_10;
        /// <summary></summary>
        public MemoryType MemoryTypes_11;
        /// <summary></summary>
        public MemoryType MemoryTypes_12;
        /// <summary></summary>
        public MemoryType MemoryTypes_13;
        /// <summary></summary>
        public MemoryType MemoryTypes_14;
        /// <summary></summary>
        public MemoryType MemoryTypes_15;
        /// <summary></summary>
        public MemoryType MemoryTypes_16;
        /// <summary></summary>
        public MemoryType MemoryTypes_17;
        /// <summary></summary>
        public MemoryType MemoryTypes_18;
        /// <summary></summary>
        public MemoryType MemoryTypes_19;
        /// <summary></summary>
        public MemoryType MemoryTypes_20;
        /// <summary></summary>
        public MemoryType MemoryTypes_21;
        /// <summary></summary>
        public MemoryType MemoryTypes_22;
        /// <summary></summary>
        public MemoryType MemoryTypes_23;
        /// <summary></summary>
        public MemoryType MemoryTypes_24;
        /// <summary></summary>
        public MemoryType MemoryTypes_25;
        /// <summary></summary>
        public MemoryType MemoryTypes_26;
        /// <summary></summary>
        public MemoryType MemoryTypes_27;
        /// <summary></summary>
        public MemoryType MemoryTypes_28;
        /// <summary></summary>
        public MemoryType MemoryTypes_29;
        /// <summary></summary>
        public MemoryType MemoryTypes_30;
        /// <summary></summary>
        public MemoryType MemoryTypes_31;
/// <summary></summary>
        public uint MemoryHeapCount;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_0;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_1;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_2;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_3;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_4;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_5;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_6;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_7;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_8;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_9;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_10;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_11;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_12;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_13;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_14;
        /// <summary></summary>
        public MemoryHeap MemoryHeaps_15;
    }
}
