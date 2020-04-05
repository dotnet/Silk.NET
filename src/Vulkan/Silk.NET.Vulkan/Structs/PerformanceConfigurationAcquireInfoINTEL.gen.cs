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
    public unsafe struct PerformanceConfigurationAcquireInfoINTEL
    {
        public PerformanceConfigurationAcquireInfoINTEL
        (
            StructureType sType = StructureType.PerformanceConfigurationAcquireInfoIntel,
            void* pNext = default,
            PerformanceConfigurationTypeINTEL type = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PerformanceConfigurationTypeINTEL Type;
    }
}
