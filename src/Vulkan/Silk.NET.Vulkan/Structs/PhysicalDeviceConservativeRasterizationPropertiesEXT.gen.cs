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
    [NativeName("Name", "VkPhysicalDeviceConservativeRasterizationPropertiesEXT")]
    public unsafe struct PhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public PhysicalDeviceConservativeRasterizationPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceConservativeRasterizationPropertiesExt,
            void* pNext = default,
            float primitiveOverestimationSize = default,
            float maxExtraPrimitiveOverestimationSize = default,
            float extraPrimitiveOverestimationSizeGranularity = default,
            Bool32 primitiveUnderestimation = default,
            Bool32 conservativePointAndLineRasterization = default,
            Bool32 degenerateTrianglesRasterized = default,
            Bool32 degenerateLinesRasterized = default,
            Bool32 fullyCoveredFragmentShaderInputVariable = default,
            Bool32 conservativeRasterizationPostDepthCoverage = default
        )
        {
           SType = sType;
           PNext = pNext;
           PrimitiveOverestimationSize = primitiveOverestimationSize;
           MaxExtraPrimitiveOverestimationSize = maxExtraPrimitiveOverestimationSize;
           ExtraPrimitiveOverestimationSizeGranularity = extraPrimitiveOverestimationSizeGranularity;
           PrimitiveUnderestimation = primitiveUnderestimation;
           ConservativePointAndLineRasterization = conservativePointAndLineRasterization;
           DegenerateTrianglesRasterized = degenerateTrianglesRasterized;
           DegenerateLinesRasterized = degenerateLinesRasterized;
           FullyCoveredFragmentShaderInputVariable = fullyCoveredFragmentShaderInputVariable;
           ConservativeRasterizationPostDepthCoverage = conservativeRasterizationPostDepthCoverage;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "primitiveOverestimationSize")]
        public float PrimitiveOverestimationSize;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxExtraPrimitiveOverestimationSize")]
        public float MaxExtraPrimitiveOverestimationSize;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "extraPrimitiveOverestimationSizeGranularity")]
        public float ExtraPrimitiveOverestimationSizeGranularity;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveUnderestimation")]
        public Bool32 PrimitiveUnderestimation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "conservativePointAndLineRasterization")]
        public Bool32 ConservativePointAndLineRasterization;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "degenerateTrianglesRasterized")]
        public Bool32 DegenerateTrianglesRasterized;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "degenerateLinesRasterized")]
        public Bool32 DegenerateLinesRasterized;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fullyCoveredFragmentShaderInputVariable")]
        public Bool32 FullyCoveredFragmentShaderInputVariable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "conservativeRasterizationPostDepthCoverage")]
        public Bool32 ConservativeRasterizationPostDepthCoverage;
    }
}
