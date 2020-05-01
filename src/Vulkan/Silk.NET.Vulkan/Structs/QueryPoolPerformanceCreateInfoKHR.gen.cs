// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct QueryPoolPerformanceCreateInfoKHR
    {
        public QueryPoolPerformanceCreateInfoKHR
        (
            StructureType sType = StructureType.QueryPoolPerformanceCreateInfoKhr,
            void* pNext = default,
            uint queueFamilyIndex = default,
            uint counterIndexCount = default,
            uint* pCounterIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           QueueFamilyIndex = queueFamilyIndex;
           CounterIndexCount = counterIndexCount;
           PCounterIndices = pCounterIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint QueueFamilyIndex;
/// <summary></summary>
        public uint CounterIndexCount;
/// <summary></summary>
        public uint* PCounterIndices;
    }
}
