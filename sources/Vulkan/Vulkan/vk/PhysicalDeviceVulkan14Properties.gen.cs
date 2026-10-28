// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan14Properties")]
public unsafe partial struct PhysicalDeviceVulkan14Properties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x4Properties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("lineSubPixelPrecisionBits")]
    public uint LineSubPixelPrecisionBits;

    [NativeName("maxVertexAttribDivisor")]
    public uint MaxVertexAttribDivisor;

    [NativeName("supportsNonZeroFirstInstance")]
    public MaybeBool<uint> SupportsNonZeroFirstInstance;

    [NativeName("maxPushDescriptors")]
    public uint MaxPushDescriptors;

    [NativeName("dynamicRenderingLocalReadDepthStencilAttachments")]
    public MaybeBool<uint> DynamicRenderingLocalReadDepthStencilAttachments;

    [NativeName("dynamicRenderingLocalReadMultisampledAttachments")]
    public MaybeBool<uint> DynamicRenderingLocalReadMultisampledAttachments;

    [NativeName("earlyFragmentMultisampleCoverageAfterSampleCounting")]
    public MaybeBool<uint> EarlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeName("earlyFragmentSampleMaskTestBeforeSampleCounting")]
    public MaybeBool<uint> EarlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeName("depthStencilSwizzleOneSupport")]
    public MaybeBool<uint> DepthStencilSwizzleOneSupport;

    [NativeName("polygonModePointSize")]
    public MaybeBool<uint> PolygonModePointSize;

    [NativeName("nonStrictSinglePixelWideLinesUseParallelogram")]
    public MaybeBool<uint> NonStrictSinglePixelWideLinesUseParallelogram;

    [NativeName("nonStrictWideLinesUseParallelogram")]
    public MaybeBool<uint> NonStrictWideLinesUseParallelogram;

    [NativeName("blockTexelViewCompatibleMultipleLayers")]
    public MaybeBool<uint> BlockTexelViewCompatibleMultipleLayers;

    [NativeName("maxCombinedImageSamplerDescriptorCount")]
    public uint MaxCombinedImageSamplerDescriptorCount;

    [NativeName("fragmentShadingRateClampCombinerInputs")]
    public MaybeBool<uint> FragmentShadingRateClampCombinerInputs;

    [NativeName("defaultRobustnessStorageBuffers")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;

    [NativeName("defaultRobustnessUniformBuffers")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;

    [NativeName("defaultRobustnessVertexInputs")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;

    [NativeName("defaultRobustnessImages")]
    public PipelineRobustnessImageBehavior DefaultRobustnessImages;

    [NativeName("copySrcLayoutCount")]
    public uint CopySrcLayoutCount;

    [NativeName("pCopySrcLayouts")]
    public ImageLayout* PCopySrcLayouts;

    [NativeName("copyDstLayoutCount")]
    public uint CopyDstLayoutCount;

    [NativeName("pCopyDstLayouts")]
    public ImageLayout* PCopyDstLayouts;

    [NativeName("optimalTilingLayoutUUID")]
    public PhysicalDeviceVulkan14PropertiesOptimalTilingLayoutUuid OptimalTilingLayoutUuid;

    [NativeName("identicalMemoryTypeRequirements")]
    public MaybeBool<uint> IdenticalMemoryTypeRequirements;

    public PhysicalDeviceVulkan14Properties() { }
}
