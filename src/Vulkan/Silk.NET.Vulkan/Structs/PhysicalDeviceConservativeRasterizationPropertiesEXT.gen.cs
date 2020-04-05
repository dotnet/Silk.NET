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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public float PrimitiveOverestimationSize;
/// <summary></summary>
        public float MaxExtraPrimitiveOverestimationSize;
/// <summary></summary>
        public float ExtraPrimitiveOverestimationSizeGranularity;
/// <summary></summary>
        public Bool32 PrimitiveUnderestimation;
/// <summary></summary>
        public Bool32 ConservativePointAndLineRasterization;
/// <summary></summary>
        public Bool32 DegenerateTrianglesRasterized;
/// <summary></summary>
        public Bool32 DegenerateLinesRasterized;
/// <summary></summary>
        public Bool32 FullyCoveredFragmentShaderInputVariable;
/// <summary></summary>
        public Bool32 ConservativeRasterizationPostDepthCoverage;
    }
}
