// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceFeatures")]
    public unsafe partial struct PhysicalDeviceFeatures
    {
        public PhysicalDeviceFeatures
        (
            Bool32? robustBufferAccess = null,
            Bool32? fullDrawIndexUint32 = null,
            Bool32? imageCubeArray = null,
            Bool32? independentBlend = null,
            Bool32? geometryShader = null,
            Bool32? tessellationShader = null,
            Bool32? sampleRateShading = null,
            Bool32? dualSrcBlend = null,
            Bool32? logicOp = null,
            Bool32? multiDrawIndirect = null,
            Bool32? drawIndirectFirstInstance = null,
            Bool32? depthClamp = null,
            Bool32? depthBiasClamp = null,
            Bool32? fillModeNonSolid = null,
            Bool32? depthBounds = null,
            Bool32? wideLines = null,
            Bool32? largePoints = null,
            Bool32? alphaToOne = null,
            Bool32? multiViewport = null,
            Bool32? samplerAnisotropy = null,
            Bool32? textureCompressionEtc2 = null,
            Bool32? textureCompressionAstcLdr = null,
            Bool32? textureCompressionBC = null,
            Bool32? occlusionQueryPrecise = null,
            Bool32? pipelineStatisticsQuery = null,
            Bool32? vertexPipelineStoresAndAtomics = null,
            Bool32? fragmentStoresAndAtomics = null,
            Bool32? shaderTessellationAndGeometryPointSize = null,
            Bool32? shaderImageGatherExtended = null,
            Bool32? shaderStorageImageExtendedFormats = null,
            Bool32? shaderStorageImageMultisample = null,
            Bool32? shaderStorageImageReadWithoutFormat = null,
            Bool32? shaderStorageImageWriteWithoutFormat = null,
            Bool32? shaderUniformBufferArrayDynamicIndexing = null,
            Bool32? shaderSampledImageArrayDynamicIndexing = null,
            Bool32? shaderStorageBufferArrayDynamicIndexing = null,
            Bool32? shaderStorageImageArrayDynamicIndexing = null,
            Bool32? shaderClipDistance = null,
            Bool32? shaderCullDistance = null,
            Bool32? shaderFloat64 = null,
            Bool32? shaderInt64 = null,
            Bool32? shaderInt16 = null,
            Bool32? shaderResourceResidency = null,
            Bool32? shaderResourceMinLod = null,
            Bool32? sparseBinding = null,
            Bool32? sparseResidencyBuffer = null,
            Bool32? sparseResidencyImage2D = null,
            Bool32? sparseResidencyImage3D = null,
            Bool32? sparseResidency2Samples = null,
            Bool32? sparseResidency4Samples = null,
            Bool32? sparseResidency8Samples = null,
            Bool32? sparseResidency16Samples = null,
            Bool32? sparseResidencyAliased = null,
            Bool32? variableMultisampleRate = null,
            Bool32? inheritedQueries = null
        ) : this()
        {
            if (robustBufferAccess is not null)
            {
                RobustBufferAccess = robustBufferAccess.Value;
            }

            if (fullDrawIndexUint32 is not null)
            {
                FullDrawIndexUint32 = fullDrawIndexUint32.Value;
            }

            if (imageCubeArray is not null)
            {
                ImageCubeArray = imageCubeArray.Value;
            }

            if (independentBlend is not null)
            {
                IndependentBlend = independentBlend.Value;
            }

            if (geometryShader is not null)
            {
                GeometryShader = geometryShader.Value;
            }

            if (tessellationShader is not null)
            {
                TessellationShader = tessellationShader.Value;
            }

            if (sampleRateShading is not null)
            {
                SampleRateShading = sampleRateShading.Value;
            }

            if (dualSrcBlend is not null)
            {
                DualSrcBlend = dualSrcBlend.Value;
            }

            if (logicOp is not null)
            {
                LogicOp = logicOp.Value;
            }

            if (multiDrawIndirect is not null)
            {
                MultiDrawIndirect = multiDrawIndirect.Value;
            }

            if (drawIndirectFirstInstance is not null)
            {
                DrawIndirectFirstInstance = drawIndirectFirstInstance.Value;
            }

            if (depthClamp is not null)
            {
                DepthClamp = depthClamp.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }

            if (fillModeNonSolid is not null)
            {
                FillModeNonSolid = fillModeNonSolid.Value;
            }

            if (depthBounds is not null)
            {
                DepthBounds = depthBounds.Value;
            }

            if (wideLines is not null)
            {
                WideLines = wideLines.Value;
            }

            if (largePoints is not null)
            {
                LargePoints = largePoints.Value;
            }

            if (alphaToOne is not null)
            {
                AlphaToOne = alphaToOne.Value;
            }

            if (multiViewport is not null)
            {
                MultiViewport = multiViewport.Value;
            }

            if (samplerAnisotropy is not null)
            {
                SamplerAnisotropy = samplerAnisotropy.Value;
            }

            if (textureCompressionEtc2 is not null)
            {
                TextureCompressionEtc2 = textureCompressionEtc2.Value;
            }

            if (textureCompressionAstcLdr is not null)
            {
                TextureCompressionAstcLdr = textureCompressionAstcLdr.Value;
            }

            if (textureCompressionBC is not null)
            {
                TextureCompressionBC = textureCompressionBC.Value;
            }

            if (occlusionQueryPrecise is not null)
            {
                OcclusionQueryPrecise = occlusionQueryPrecise.Value;
            }

            if (pipelineStatisticsQuery is not null)
            {
                PipelineStatisticsQuery = pipelineStatisticsQuery.Value;
            }

            if (vertexPipelineStoresAndAtomics is not null)
            {
                VertexPipelineStoresAndAtomics = vertexPipelineStoresAndAtomics.Value;
            }

            if (fragmentStoresAndAtomics is not null)
            {
                FragmentStoresAndAtomics = fragmentStoresAndAtomics.Value;
            }

            if (shaderTessellationAndGeometryPointSize is not null)
            {
                ShaderTessellationAndGeometryPointSize = shaderTessellationAndGeometryPointSize.Value;
            }

            if (shaderImageGatherExtended is not null)
            {
                ShaderImageGatherExtended = shaderImageGatherExtended.Value;
            }

            if (shaderStorageImageExtendedFormats is not null)
            {
                ShaderStorageImageExtendedFormats = shaderStorageImageExtendedFormats.Value;
            }

            if (shaderStorageImageMultisample is not null)
            {
                ShaderStorageImageMultisample = shaderStorageImageMultisample.Value;
            }

            if (shaderStorageImageReadWithoutFormat is not null)
            {
                ShaderStorageImageReadWithoutFormat = shaderStorageImageReadWithoutFormat.Value;
            }

            if (shaderStorageImageWriteWithoutFormat is not null)
            {
                ShaderStorageImageWriteWithoutFormat = shaderStorageImageWriteWithoutFormat.Value;
            }

            if (shaderUniformBufferArrayDynamicIndexing is not null)
            {
                ShaderUniformBufferArrayDynamicIndexing = shaderUniformBufferArrayDynamicIndexing.Value;
            }

            if (shaderSampledImageArrayDynamicIndexing is not null)
            {
                ShaderSampledImageArrayDynamicIndexing = shaderSampledImageArrayDynamicIndexing.Value;
            }

            if (shaderStorageBufferArrayDynamicIndexing is not null)
            {
                ShaderStorageBufferArrayDynamicIndexing = shaderStorageBufferArrayDynamicIndexing.Value;
            }

            if (shaderStorageImageArrayDynamicIndexing is not null)
            {
                ShaderStorageImageArrayDynamicIndexing = shaderStorageImageArrayDynamicIndexing.Value;
            }

            if (shaderClipDistance is not null)
            {
                ShaderClipDistance = shaderClipDistance.Value;
            }

            if (shaderCullDistance is not null)
            {
                ShaderCullDistance = shaderCullDistance.Value;
            }

            if (shaderFloat64 is not null)
            {
                ShaderFloat64 = shaderFloat64.Value;
            }

            if (shaderInt64 is not null)
            {
                ShaderInt64 = shaderInt64.Value;
            }

            if (shaderInt16 is not null)
            {
                ShaderInt16 = shaderInt16.Value;
            }

            if (shaderResourceResidency is not null)
            {
                ShaderResourceResidency = shaderResourceResidency.Value;
            }

            if (shaderResourceMinLod is not null)
            {
                ShaderResourceMinLod = shaderResourceMinLod.Value;
            }

            if (sparseBinding is not null)
            {
                SparseBinding = sparseBinding.Value;
            }

            if (sparseResidencyBuffer is not null)
            {
                SparseResidencyBuffer = sparseResidencyBuffer.Value;
            }

            if (sparseResidencyImage2D is not null)
            {
                SparseResidencyImage2D = sparseResidencyImage2D.Value;
            }

            if (sparseResidencyImage3D is not null)
            {
                SparseResidencyImage3D = sparseResidencyImage3D.Value;
            }

            if (sparseResidency2Samples is not null)
            {
                SparseResidency2Samples = sparseResidency2Samples.Value;
            }

            if (sparseResidency4Samples is not null)
            {
                SparseResidency4Samples = sparseResidency4Samples.Value;
            }

            if (sparseResidency8Samples is not null)
            {
                SparseResidency8Samples = sparseResidency8Samples.Value;
            }

            if (sparseResidency16Samples is not null)
            {
                SparseResidency16Samples = sparseResidency16Samples.Value;
            }

            if (sparseResidencyAliased is not null)
            {
                SparseResidencyAliased = sparseResidencyAliased.Value;
            }

            if (variableMultisampleRate is not null)
            {
                VariableMultisampleRate = variableMultisampleRate.Value;
            }

            if (inheritedQueries is not null)
            {
                InheritedQueries = inheritedQueries.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "robustBufferAccess")]
        public Bool32 RobustBufferAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fullDrawIndexUint32")]
        public Bool32 FullDrawIndexUint32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "imageCubeArray")]
        public Bool32 ImageCubeArray;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "independentBlend")]
        public Bool32 IndependentBlend;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "geometryShader")]
        public Bool32 GeometryShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tessellationShader")]
        public Bool32 TessellationShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sampleRateShading")]
        public Bool32 SampleRateShading;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dualSrcBlend")]
        public Bool32 DualSrcBlend;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "logicOp")]
        public Bool32 LogicOp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiDrawIndirect")]
        public Bool32 MultiDrawIndirect;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "drawIndirectFirstInstance")]
        public Bool32 DrawIndirectFirstInstance;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthClamp")]
        public Bool32 DepthClamp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBiasClamp")]
        public Bool32 DepthBiasClamp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fillModeNonSolid")]
        public Bool32 FillModeNonSolid;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBounds")]
        public Bool32 DepthBounds;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "wideLines")]
        public Bool32 WideLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "largePoints")]
        public Bool32 LargePoints;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "alphaToOne")]
        public Bool32 AlphaToOne;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiViewport")]
        public Bool32 MultiViewport;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "samplerAnisotropy")]
        public Bool32 SamplerAnisotropy;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "textureCompressionETC2")]
        public Bool32 TextureCompressionEtc2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "textureCompressionASTC_LDR")]
        public Bool32 TextureCompressionAstcLdr;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "textureCompressionBC")]
        public Bool32 TextureCompressionBC;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "occlusionQueryPrecise")]
        public Bool32 OcclusionQueryPrecise;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineStatisticsQuery")]
        public Bool32 PipelineStatisticsQuery;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexPipelineStoresAndAtomics")]
        public Bool32 VertexPipelineStoresAndAtomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentStoresAndAtomics")]
        public Bool32 FragmentStoresAndAtomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTessellationAndGeometryPointSize")]
        public Bool32 ShaderTessellationAndGeometryPointSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderImageGatherExtended")]
        public Bool32 ShaderImageGatherExtended;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageExtendedFormats")]
        public Bool32 ShaderStorageImageExtendedFormats;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageMultisample")]
        public Bool32 ShaderStorageImageMultisample;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageReadWithoutFormat")]
        public Bool32 ShaderStorageImageReadWithoutFormat;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageWriteWithoutFormat")]
        public Bool32 ShaderStorageImageWriteWithoutFormat;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderUniformBufferArrayDynamicIndexing")]
        public Bool32 ShaderUniformBufferArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSampledImageArrayDynamicIndexing")]
        public Bool32 ShaderSampledImageArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageBufferArrayDynamicIndexing")]
        public Bool32 ShaderStorageBufferArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageImageArrayDynamicIndexing")]
        public Bool32 ShaderStorageImageArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderClipDistance")]
        public Bool32 ShaderClipDistance;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderCullDistance")]
        public Bool32 ShaderCullDistance;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderFloat64")]
        public Bool32 ShaderFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInt64")]
        public Bool32 ShaderInt64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInt16")]
        public Bool32 ShaderInt16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderResourceResidency")]
        public Bool32 ShaderResourceResidency;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderResourceMinLod")]
        public Bool32 ShaderResourceMinLod;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseBinding")]
        public Bool32 SparseBinding;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidencyBuffer")]
        public Bool32 SparseResidencyBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidencyImage2D")]
        public Bool32 SparseResidencyImage2D;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidencyImage3D")]
        public Bool32 SparseResidencyImage3D;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidency2Samples")]
        public Bool32 SparseResidency2Samples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidency4Samples")]
        public Bool32 SparseResidency4Samples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidency8Samples")]
        public Bool32 SparseResidency8Samples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidency16Samples")]
        public Bool32 SparseResidency16Samples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseResidencyAliased")]
        public Bool32 SparseResidencyAliased;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "variableMultisampleRate")]
        public Bool32 VariableMultisampleRate;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "inheritedQueries")]
        public Bool32 InheritedQueries;
    }
}
