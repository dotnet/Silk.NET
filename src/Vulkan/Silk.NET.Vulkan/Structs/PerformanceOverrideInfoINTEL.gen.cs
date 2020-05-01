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
    public unsafe struct PerformanceOverrideInfoINTEL
    {
        public PerformanceOverrideInfoINTEL
        (
            StructureType sType = StructureType.PerformanceOverrideInfoIntel,
            void* pNext = default,
            PerformanceOverrideTypeINTEL type = default,
            Bool32 enable = default,
            ulong parameter = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           Enable = enable;
           Parameter = parameter;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PerformanceOverrideTypeINTEL Type;
/// <summary></summary>
        public Bool32 Enable;
/// <summary></summary>
        public ulong Parameter;
    }
}
