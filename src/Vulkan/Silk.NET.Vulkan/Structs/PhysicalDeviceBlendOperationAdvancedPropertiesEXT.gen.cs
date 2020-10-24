// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public PhysicalDeviceBlendOperationAdvancedPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt,
            void* pNext = null,
            uint? advancedBlendMaxColorAttachments = null,
            Bool32? advancedBlendIndependentBlend = null,
            Bool32? advancedBlendNonPremultipliedSrcColor = null,
            Bool32? advancedBlendNonPremultipliedDstColor = null,
            Bool32? advancedBlendCorrelatedOverlap = null,
            Bool32? advancedBlendAllOperations = null
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

            if (advancedBlendMaxColorAttachments is not null)
            {
                AdvancedBlendMaxColorAttachments = advancedBlendMaxColorAttachments.Value;
            }

            if (advancedBlendIndependentBlend is not null)
            {
                AdvancedBlendIndependentBlend = advancedBlendIndependentBlend.Value;
            }

            if (advancedBlendNonPremultipliedSrcColor is not null)
            {
                AdvancedBlendNonPremultipliedSrcColor = advancedBlendNonPremultipliedSrcColor.Value;
            }

            if (advancedBlendNonPremultipliedDstColor is not null)
            {
                AdvancedBlendNonPremultipliedDstColor = advancedBlendNonPremultipliedDstColor.Value;
            }

            if (advancedBlendCorrelatedOverlap is not null)
            {
                AdvancedBlendCorrelatedOverlap = advancedBlendCorrelatedOverlap.Value;
            }

            if (advancedBlendAllOperations is not null)
            {
                AdvancedBlendAllOperations = advancedBlendAllOperations.Value;
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
