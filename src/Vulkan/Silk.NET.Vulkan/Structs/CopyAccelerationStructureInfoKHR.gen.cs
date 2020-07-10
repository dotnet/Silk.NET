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
    [NativeName("Name", "VkCopyAccelerationStructureInfoKHR")]
    public unsafe partial struct CopyAccelerationStructureInfoKHR
    {
        public CopyAccelerationStructureInfoKHR
        (
            StructureType sType = StructureType.CopyAccelerationStructureInfoKhr,
            void* pNext = default,
            AccelerationStructureKHR src = default,
            AccelerationStructureKHR dst = default,
            CopyAccelerationStructureModeKHR mode = default
        )
        {
            SType = sType;
            PNext = pNext;
            Src = src;
            Dst = dst;
            Mode = mode;
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
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "src")]
        public AccelerationStructureKHR Src;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "dst")]
        public AccelerationStructureKHR Dst;
/// <summary></summary>
        [NativeName("Type", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Type.Name", "VkCopyAccelerationStructureModeKHR")]
        [NativeName("Name", "mode")]
        public CopyAccelerationStructureModeKHR Mode;
    }
}
