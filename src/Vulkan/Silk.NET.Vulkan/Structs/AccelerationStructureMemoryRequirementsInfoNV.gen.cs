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
    public unsafe struct AccelerationStructureMemoryRequirementsInfoNV
    {
        public AccelerationStructureMemoryRequirementsInfoNV
        (
            StructureType sType = StructureType.AccelerationStructureMemoryRequirementsInfoNV,
            void* pNext = default,
            AccelerationStructureMemoryRequirementsTypeNV type = default,
            AccelerationStructureNV accelerationStructure = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           AccelerationStructure = accelerationStructure;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccelerationStructureMemoryRequirementsTypeNV Type;
/// <summary></summary>
        public AccelerationStructureNV AccelerationStructure;
    }
}
