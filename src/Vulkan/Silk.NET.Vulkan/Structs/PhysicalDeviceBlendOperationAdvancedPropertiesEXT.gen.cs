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
    [NativeName("Name", "VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "advancedBlendMaxColorAttachments")]
        public uint AdvancedBlendMaxColorAttachments;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "advancedBlendIndependentBlend")]
        public Bool32 AdvancedBlendIndependentBlend;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "advancedBlendNonPremultipliedSrcColor")]
        public Bool32 AdvancedBlendNonPremultipliedSrcColor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "advancedBlendNonPremultipliedDstColor")]
        public Bool32 AdvancedBlendNonPremultipliedDstColor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "advancedBlendCorrelatedOverlap")]
        public Bool32 AdvancedBlendCorrelatedOverlap;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "advancedBlendAllOperations")]
        public Bool32 AdvancedBlendAllOperations;
    }
}
