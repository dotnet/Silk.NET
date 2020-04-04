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
    public unsafe struct PerformanceCounterKHR
    {
        public PerformanceCounterKHR
        (
            StructureType sType = StructureType.PerformanceCounterKhr,
            void* pNext = default,
            PerformanceCounterUnitKHR unit = default,
            PerformanceCounterScopeKHR scope = default,
            PerformanceCounterStorageKHR storage = default
        )
        {
           SType = sType;
           PNext = pNext;
           Unit = unit;
           Scope = scope;
           Storage = storage;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PerformanceCounterUnitKHR Unit;
/// <summary></summary>
        public PerformanceCounterScopeKHR Scope;
/// <summary></summary>
        public PerformanceCounterStorageKHR Storage;
        /// <summary></summary>
       public fixed byte Uuid[16];
    }
}
