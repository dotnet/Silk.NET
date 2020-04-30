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
    public unsafe struct AccelerationStructureMemoryRequirementsInfoKHR
    {
        public AccelerationStructureMemoryRequirementsInfoKHR
        (
            StructureType sType = StructureType.AccelerationStructureMemoryRequirementsInfoKhr,
            void* pNext = default,
            AccelerationStructureMemoryRequirementsTypeKHR type = default,
            AccelerationStructureBuildTypeKHR buildType = default,
            AccelerationStructureKHR accelerationStructure = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           BuildType = buildType;
           AccelerationStructure = accelerationStructure;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccelerationStructureMemoryRequirementsTypeKHR Type;
/// <summary></summary>
        public AccelerationStructureBuildTypeKHR BuildType;
/// <summary></summary>
        public AccelerationStructureKHR AccelerationStructure;
    }
}
