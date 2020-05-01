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
    public unsafe struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public PhysicalDeviceBlendOperationAdvancedPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt,
            void* pNext = default,
            uint advancedBlendMaxColorAttachments = default,
            Bool32 advancedBlendIndependentBlend = default,
            Bool32 advancedBlendNonPremultipliedSrcColor = default,
            Bool32 advancedBlendNonPremultipliedDstColor = default,
            Bool32 advancedBlendCorrelatedOverlap = default,
            Bool32 advancedBlendAllOperations = default
        )
        {
           SType = sType;
           PNext = pNext;
           AdvancedBlendMaxColorAttachments = advancedBlendMaxColorAttachments;
           AdvancedBlendIndependentBlend = advancedBlendIndependentBlend;
           AdvancedBlendNonPremultipliedSrcColor = advancedBlendNonPremultipliedSrcColor;
           AdvancedBlendNonPremultipliedDstColor = advancedBlendNonPremultipliedDstColor;
           AdvancedBlendCorrelatedOverlap = advancedBlendCorrelatedOverlap;
           AdvancedBlendAllOperations = advancedBlendAllOperations;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint AdvancedBlendMaxColorAttachments;
/// <summary></summary>
        public Bool32 AdvancedBlendIndependentBlend;
/// <summary></summary>
        public Bool32 AdvancedBlendNonPremultipliedSrcColor;
/// <summary></summary>
        public Bool32 AdvancedBlendNonPremultipliedDstColor;
/// <summary></summary>
        public Bool32 AdvancedBlendCorrelatedOverlap;
/// <summary></summary>
        public Bool32 AdvancedBlendAllOperations;
    }
}
