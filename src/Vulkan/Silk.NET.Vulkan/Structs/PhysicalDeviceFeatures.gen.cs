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
    public unsafe struct PhysicalDeviceFeatures
    {
        public PhysicalDeviceFeatures
        (
            Bool32 robustBufferAccess = default,
            Bool32 fullDrawIndexUint32 = default,
            Bool32 imageCubeArray = default,
            Bool32 independentBlend = default,
            Bool32 geometryShader = default,
            Bool32 tessellationShader = default,
            Bool32 sampleRateShading = default,
            Bool32 dualSrcBlend = default,
            Bool32 logicOp = default,
            Bool32 multiDrawIndirect = default,
            Bool32 drawIndirectFirstInstance = default,
            Bool32 depthClamp = default,
            Bool32 depthBiasClamp = default,
            Bool32 fillModeNonSolid = default,
            Bool32 depthBounds = default,
            Bool32 wideLines = default,
            Bool32 largePoints = default,
            Bool32 alphaToOne = default,
            Bool32 multiViewport = default,
            Bool32 samplerAnisotropy = default,
            Bool32 textureCompressionEtc2 = default,
            Bool32 textureCompressionAstcLdr = default,
            Bool32 textureCompressionBC = default,
            Bool32 occlusionQueryPrecise = default,
            Bool32 pipelineStatisticsQuery = default,
            Bool32 vertexPipelineStoresAndAtomics = default,
            Bool32 fragmentStoresAndAtomics = default,
            Bool32 shaderTessellationAndGeometryPointSize = default,
            Bool32 shaderImageGatherExtended = default,
            Bool32 shaderStorageImageExtendedFormats = default,
            Bool32 shaderStorageImageMultisample = default,
            Bool32 shaderStorageImageReadWithoutFormat = default,
            Bool32 shaderStorageImageWriteWithoutFormat = default,
            Bool32 shaderUniformBufferArrayDynamicIndexing = default,
            Bool32 shaderSampledImageArrayDynamicIndexing = default,
            Bool32 shaderStorageBufferArrayDynamicIndexing = default,
            Bool32 shaderStorageImageArrayDynamicIndexing = default,
            Bool32 shaderClipDistance = default,
            Bool32 shaderCullDistance = default,
            Bool32 shaderFloat64 = default,
            Bool32 shaderInt64 = default,
            Bool32 shaderInt16 = default,
            Bool32 shaderResourceResidency = default,
            Bool32 shaderResourceMinLod = default,
            Bool32 sparseBinding = default,
            Bool32 sparseResidencyBuffer = default,
            Bool32 sparseResidencyImage2D = default,
            Bool32 sparseResidencyImage3D = default,
            Bool32 sparseResidency2Samples = default,
            Bool32 sparseResidency4Samples = default,
            Bool32 sparseResidency8Samples = default,
            Bool32 sparseResidency16Samples = default,
            Bool32 sparseResidencyAliased = default,
            Bool32 variableMultisampleRate = default,
            Bool32 inheritedQueries = default
        )
        {
           RobustBufferAccess = robustBufferAccess;
           FullDrawIndexUint32 = fullDrawIndexUint32;
           ImageCubeArray = imageCubeArray;
           IndependentBlend = independentBlend;
           GeometryShader = geometryShader;
           TessellationShader = tessellationShader;
           SampleRateShading = sampleRateShading;
           DualSrcBlend = dualSrcBlend;
           LogicOp = logicOp;
           MultiDrawIndirect = multiDrawIndirect;
           DrawIndirectFirstInstance = drawIndirectFirstInstance;
           DepthClamp = depthClamp;
           DepthBiasClamp = depthBiasClamp;
           FillModeNonSolid = fillModeNonSolid;
           DepthBounds = depthBounds;
           WideLines = wideLines;
           LargePoints = largePoints;
           AlphaToOne = alphaToOne;
           MultiViewport = multiViewport;
           SamplerAnisotropy = samplerAnisotropy;
           TextureCompressionEtc2 = textureCompressionEtc2;
           TextureCompressionAstcLdr = textureCompressionAstcLdr;
           TextureCompressionBC = textureCompressionBC;
           OcclusionQueryPrecise = occlusionQueryPrecise;
           PipelineStatisticsQuery = pipelineStatisticsQuery;
           VertexPipelineStoresAndAtomics = vertexPipelineStoresAndAtomics;
           FragmentStoresAndAtomics = fragmentStoresAndAtomics;
           ShaderTessellationAndGeometryPointSize = shaderTessellationAndGeometryPointSize;
           ShaderImageGatherExtended = shaderImageGatherExtended;
           ShaderStorageImageExtendedFormats = shaderStorageImageExtendedFormats;
           ShaderStorageImageMultisample = shaderStorageImageMultisample;
           ShaderStorageImageReadWithoutFormat = shaderStorageImageReadWithoutFormat;
           ShaderStorageImageWriteWithoutFormat = shaderStorageImageWriteWithoutFormat;
           ShaderUniformBufferArrayDynamicIndexing = shaderUniformBufferArrayDynamicIndexing;
           ShaderSampledImageArrayDynamicIndexing = shaderSampledImageArrayDynamicIndexing;
           ShaderStorageBufferArrayDynamicIndexing = shaderStorageBufferArrayDynamicIndexing;
           ShaderStorageImageArrayDynamicIndexing = shaderStorageImageArrayDynamicIndexing;
           ShaderClipDistance = shaderClipDistance;
           ShaderCullDistance = shaderCullDistance;
           ShaderFloat64 = shaderFloat64;
           ShaderInt64 = shaderInt64;
           ShaderInt16 = shaderInt16;
           ShaderResourceResidency = shaderResourceResidency;
           ShaderResourceMinLod = shaderResourceMinLod;
           SparseBinding = sparseBinding;
           SparseResidencyBuffer = sparseResidencyBuffer;
           SparseResidencyImage2D = sparseResidencyImage2D;
           SparseResidencyImage3D = sparseResidencyImage3D;
           SparseResidency2Samples = sparseResidency2Samples;
           SparseResidency4Samples = sparseResidency4Samples;
           SparseResidency8Samples = sparseResidency8Samples;
           SparseResidency16Samples = sparseResidency16Samples;
           SparseResidencyAliased = sparseResidencyAliased;
           VariableMultisampleRate = variableMultisampleRate;
           InheritedQueries = inheritedQueries;
        }

/// <summary></summary>
        public Bool32 RobustBufferAccess;
/// <summary></summary>
        public Bool32 FullDrawIndexUint32;
/// <summary></summary>
        public Bool32 ImageCubeArray;
/// <summary></summary>
        public Bool32 IndependentBlend;
/// <summary></summary>
        public Bool32 GeometryShader;
/// <summary></summary>
        public Bool32 TessellationShader;
/// <summary></summary>
        public Bool32 SampleRateShading;
/// <summary></summary>
        public Bool32 DualSrcBlend;
/// <summary></summary>
        public Bool32 LogicOp;
/// <summary></summary>
        public Bool32 MultiDrawIndirect;
/// <summary></summary>
        public Bool32 DrawIndirectFirstInstance;
/// <summary></summary>
        public Bool32 DepthClamp;
/// <summary></summary>
        public Bool32 DepthBiasClamp;
/// <summary></summary>
        public Bool32 FillModeNonSolid;
/// <summary></summary>
        public Bool32 DepthBounds;
/// <summary></summary>
        public Bool32 WideLines;
/// <summary></summary>
        public Bool32 LargePoints;
/// <summary></summary>
        public Bool32 AlphaToOne;
/// <summary></summary>
        public Bool32 MultiViewport;
/// <summary></summary>
        public Bool32 SamplerAnisotropy;
/// <summary></summary>
        public Bool32 TextureCompressionEtc2;
/// <summary></summary>
        public Bool32 TextureCompressionAstcLdr;
/// <summary></summary>
        public Bool32 TextureCompressionBC;
/// <summary></summary>
        public Bool32 OcclusionQueryPrecise;
/// <summary></summary>
        public Bool32 PipelineStatisticsQuery;
/// <summary></summary>
        public Bool32 VertexPipelineStoresAndAtomics;
/// <summary></summary>
        public Bool32 FragmentStoresAndAtomics;
/// <summary></summary>
        public Bool32 ShaderTessellationAndGeometryPointSize;
/// <summary></summary>
        public Bool32 ShaderImageGatherExtended;
/// <summary></summary>
        public Bool32 ShaderStorageImageExtendedFormats;
/// <summary></summary>
        public Bool32 ShaderStorageImageMultisample;
/// <summary></summary>
        public Bool32 ShaderStorageImageReadWithoutFormat;
/// <summary></summary>
        public Bool32 ShaderStorageImageWriteWithoutFormat;
/// <summary></summary>
        public Bool32 ShaderUniformBufferArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderSampledImageArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageBufferArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderStorageImageArrayDynamicIndexing;
/// <summary></summary>
        public Bool32 ShaderClipDistance;
/// <summary></summary>
        public Bool32 ShaderCullDistance;
/// <summary></summary>
        public Bool32 ShaderFloat64;
/// <summary></summary>
        public Bool32 ShaderInt64;
/// <summary></summary>
        public Bool32 ShaderInt16;
/// <summary></summary>
        public Bool32 ShaderResourceResidency;
/// <summary></summary>
        public Bool32 ShaderResourceMinLod;
/// <summary></summary>
        public Bool32 SparseBinding;
/// <summary></summary>
        public Bool32 SparseResidencyBuffer;
/// <summary></summary>
        public Bool32 SparseResidencyImage2D;
/// <summary></summary>
        public Bool32 SparseResidencyImage3D;
/// <summary></summary>
        public Bool32 SparseResidency2Samples;
/// <summary></summary>
        public Bool32 SparseResidency4Samples;
/// <summary></summary>
        public Bool32 SparseResidency8Samples;
/// <summary></summary>
        public Bool32 SparseResidency16Samples;
/// <summary></summary>
        public Bool32 SparseResidencyAliased;
/// <summary></summary>
        public Bool32 VariableMultisampleRate;
/// <summary></summary>
        public Bool32 InheritedQueries;
    }
}
