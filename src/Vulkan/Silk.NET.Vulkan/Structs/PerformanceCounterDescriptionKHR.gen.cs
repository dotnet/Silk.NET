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
    [NativeName("Name", "VkPerformanceCounterDescriptionKHR")]
    public unsafe partial struct PerformanceCounterDescriptionKHR
    {
        public PerformanceCounterDescriptionKHR
        (
            StructureType sType = StructureType.PerformanceCounterDescriptionKhr,
            void* pNext = default,
            PerformanceCounterDescriptionFlagsKHR flags = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
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
        [NativeName("Type", "VkPerformanceCounterDescriptionFlagsKHR")]
        [NativeName("Type.Name", "VkPerformanceCounterDescriptionFlagsKHR")]
        [NativeName("Name", "flags")]
        public PerformanceCounterDescriptionFlagsKHR Flags;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "category")]
        public fixed byte Category[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
    }
}
