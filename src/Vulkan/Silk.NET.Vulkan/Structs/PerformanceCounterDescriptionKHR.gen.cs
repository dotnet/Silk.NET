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
    public unsafe struct PerformanceCounterDescriptionKHR
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PerformanceCounterDescriptionFlagsKHR Flags;
        /// <summary></summary>
       public fixed byte Name[256];
        /// <summary></summary>
       public fixed byte Category[256];
        /// <summary></summary>
       public fixed byte Description[256];
    }
}
