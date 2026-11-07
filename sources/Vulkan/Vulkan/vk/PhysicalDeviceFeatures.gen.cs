// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFeatures")]
public partial struct PhysicalDeviceFeatures
{
    [NativeName("robustBufferAccess")]
    public MaybeBool<uint> RobustBufferAccess;

    [NativeName("fullDrawIndexUint32")]
    public MaybeBool<uint> FullDrawIndexUint32;

    [NativeName("imageCubeArray")]
    public MaybeBool<uint> ImageCubeArray;

    [NativeName("independentBlend")]
    public MaybeBool<uint> IndependentBlend;

    [NativeName("geometryShader")]
    public MaybeBool<uint> GeometryShader;

    [NativeName("tessellationShader")]
    public MaybeBool<uint> TessellationShader;

    [NativeName("sampleRateShading")]
    public MaybeBool<uint> SampleRateShading;

    [NativeName("dualSrcBlend")]
    public MaybeBool<uint> DualSrcBlend;

    [NativeName("logicOp")]
    public MaybeBool<uint> LogicOp;

    [NativeName("multiDrawIndirect")]
    public MaybeBool<uint> MultiDrawIndirect;

    [NativeName("drawIndirectFirstInstance")]
    public MaybeBool<uint> DrawIndirectFirstInstance;

    [NativeName("depthClamp")]
    public MaybeBool<uint> DepthClamp;

    [NativeName("depthBiasClamp")]
    public MaybeBool<uint> DepthBiasClamp;

    [NativeName("fillModeNonSolid")]
    public MaybeBool<uint> FillModeNonSolid;

    [NativeName("depthBounds")]
    public MaybeBool<uint> DepthBounds;

    [NativeName("wideLines")]
    public MaybeBool<uint> WideLines;

    [NativeName("largePoints")]
    public MaybeBool<uint> LargePoints;

    [NativeName("alphaToOne")]
    public MaybeBool<uint> AlphaToOne;

    [NativeName("multiViewport")]
    public MaybeBool<uint> MultiViewport;

    [NativeName("samplerAnisotropy")]
    public MaybeBool<uint> SamplerAnisotropy;

    [NativeName("textureCompressionETC2")]
    public MaybeBool<uint> TextureCompressionEtc2;

    [NativeName("textureCompressionASTC_LDR")]
    public MaybeBool<uint> TextureCompressionAstcLdr;

    [NativeName("textureCompressionBC")]
    public MaybeBool<uint> TextureCompressionBC;

    [NativeName("occlusionQueryPrecise")]
    public MaybeBool<uint> OcclusionQueryPrecise;

    [NativeName("pipelineStatisticsQuery")]
    public MaybeBool<uint> PipelineStatisticsQuery;

    [NativeName("vertexPipelineStoresAndAtomics")]
    public MaybeBool<uint> VertexPipelineStoresAndAtomics;

    [NativeName("fragmentStoresAndAtomics")]
    public MaybeBool<uint> FragmentStoresAndAtomics;

    [NativeName("shaderTessellationAndGeometryPointSize")]
    public MaybeBool<uint> ShaderTessellationAndGeometryPointSize;

    [NativeName("shaderImageGatherExtended")]
    public MaybeBool<uint> ShaderImageGatherExtended;

    [NativeName("shaderStorageImageExtendedFormats")]
    public MaybeBool<uint> ShaderStorageImageExtendedFormats;

    [NativeName("shaderStorageImageMultisample")]
    public MaybeBool<uint> ShaderStorageImageMultisample;

    [NativeName("shaderStorageImageReadWithoutFormat")]
    public MaybeBool<uint> ShaderStorageImageReadWithoutFormat;

    [NativeName("shaderStorageImageWriteWithoutFormat")]
    public MaybeBool<uint> ShaderStorageImageWriteWithoutFormat;

    [NativeName("shaderUniformBufferArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderUniformBufferArrayDynamicIndexing;

    [NativeName("shaderSampledImageArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderSampledImageArrayDynamicIndexing;

    [NativeName("shaderStorageBufferArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderStorageBufferArrayDynamicIndexing;

    [NativeName("shaderStorageImageArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderStorageImageArrayDynamicIndexing;

    [NativeName("shaderClipDistance")]
    public MaybeBool<uint> ShaderClipDistance;

    [NativeName("shaderCullDistance")]
    public MaybeBool<uint> ShaderCullDistance;

    [NativeName("shaderFloat64")]
    public MaybeBool<uint> ShaderFloat64;

    [NativeName("shaderInt64")]
    public MaybeBool<uint> ShaderInt64;

    [NativeName("shaderInt16")]
    public MaybeBool<uint> ShaderInt16;

    [NativeName("shaderResourceResidency")]
    public MaybeBool<uint> ShaderResourceResidency;

    [NativeName("shaderResourceMinLod")]
    public MaybeBool<uint> ShaderResourceMinLod;

    [NativeName("sparseBinding")]
    public MaybeBool<uint> SparseBinding;

    [NativeName("sparseResidencyBuffer")]
    public MaybeBool<uint> SparseResidencyBuffer;

    [NativeName("sparseResidencyImage2D")]
    public MaybeBool<uint> SparseResidencyImage2D;

    [NativeName("sparseResidencyImage3D")]
    public MaybeBool<uint> SparseResidencyImage3D;

    [NativeName("sparseResidency2Samples")]
    public MaybeBool<uint> SparseResidency2Samples;

    [NativeName("sparseResidency4Samples")]
    public MaybeBool<uint> SparseResidency4Samples;

    [NativeName("sparseResidency8Samples")]
    public MaybeBool<uint> SparseResidency8Samples;

    [NativeName("sparseResidency16Samples")]
    public MaybeBool<uint> SparseResidency16Samples;

    [NativeName("sparseResidencyAliased")]
    public MaybeBool<uint> SparseResidencyAliased;

    [NativeName("variableMultisampleRate")]
    public MaybeBool<uint> VariableMultisampleRate;

    [NativeName("inheritedQueries")]
    public MaybeBool<uint> InheritedQueries;
}
