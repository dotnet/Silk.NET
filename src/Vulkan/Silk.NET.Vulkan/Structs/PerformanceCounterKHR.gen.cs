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
    [NativeName("Name", "VkPerformanceCounterKHR")]
    public unsafe partial struct PerformanceCounterKHR
    {
        public PerformanceCounterKHR
        (
            StructureType? sType = StructureType.PerformanceCounterKhr,
            void* pNext = null,
            PerformanceCounterUnitKHR? unit = null,
            PerformanceCounterScopeKHR? scope = null,
            PerformanceCounterStorageKHR? storage = null
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

            if (unit is not null)
            {
                Unit = unit.Value;
            }

            if (scope is not null)
            {
                Scope = scope.Value;
            }

            if (storage is not null)
            {
                Storage = storage.Value;
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
        [NativeName("Type", "VkPerformanceCounterUnitKHR")]
        [NativeName("Type.Name", "VkPerformanceCounterUnitKHR")]
        [NativeName("Name", "unit")]
        public PerformanceCounterUnitKHR Unit;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceCounterScopeKHR")]
        [NativeName("Type.Name", "VkPerformanceCounterScopeKHR")]
        [NativeName("Name", "scope")]
        public PerformanceCounterScopeKHR Scope;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceCounterStorageKHR")]
        [NativeName("Type.Name", "VkPerformanceCounterStorageKHR")]
        [NativeName("Name", "storage")]
        public PerformanceCounterStorageKHR Storage;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "uuid")]
        public fixed byte Uuid[16];
    }
}
