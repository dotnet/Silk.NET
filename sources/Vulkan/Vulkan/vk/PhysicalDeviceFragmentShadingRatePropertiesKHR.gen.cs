// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentShadingRatePropertiesKHR")]
public unsafe partial struct PhysicalDeviceFragmentShadingRatePropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("minFragmentShadingRateAttachmentTexelSize")]
    public Extent2D MinFragmentShadingRateAttachmentTexelSize;

    [NativeName("maxFragmentShadingRateAttachmentTexelSize")]
    public Extent2D MaxFragmentShadingRateAttachmentTexelSize;

    [NativeName("maxFragmentShadingRateAttachmentTexelSizeAspectRatio")]
    public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;

    [NativeName("primitiveFragmentShadingRateWithMultipleViewports")]
    public MaybeBool<uint> PrimitiveFragmentShadingRateWithMultipleViewports;

    [NativeName("layeredShadingRateAttachments")]
    public MaybeBool<uint> LayeredShadingRateAttachments;

    [NativeName("fragmentShadingRateNonTrivialCombinerOps")]
    public MaybeBool<uint> FragmentShadingRateNonTrivialCombinerOps;

    [NativeName("maxFragmentSize")]
    public Extent2D MaxFragmentSize;

    [NativeName("maxFragmentSizeAspectRatio")]
    public uint MaxFragmentSizeAspectRatio;

    [NativeName("maxFragmentShadingRateCoverageSamples")]
    public uint MaxFragmentShadingRateCoverageSamples;

    [NativeName("maxFragmentShadingRateRasterizationSamples")]
    public SampleCountFlags MaxFragmentShadingRateRasterizationSamples;

    [NativeName("fragmentShadingRateWithShaderDepthStencilWrites")]
    public MaybeBool<uint> FragmentShadingRateWithShaderDepthStencilWrites;

    [NativeName("fragmentShadingRateWithSampleMask")]
    public MaybeBool<uint> FragmentShadingRateWithSampleMask;

    [NativeName("fragmentShadingRateWithShaderSampleMask")]
    public MaybeBool<uint> FragmentShadingRateWithShaderSampleMask;

    [NativeName("fragmentShadingRateWithConservativeRasterization")]
    public MaybeBool<uint> FragmentShadingRateWithConservativeRasterization;

    [NativeName("fragmentShadingRateWithFragmentShaderInterlock")]
    public MaybeBool<uint> FragmentShadingRateWithFragmentShaderInterlock;

    [NativeName("fragmentShadingRateWithCustomSampleLocations")]
    public MaybeBool<uint> FragmentShadingRateWithCustomSampleLocations;

    [NativeName("fragmentShadingRateStrictMultiplyCombiner")]
    public MaybeBool<uint> FragmentShadingRateStrictMultiplyCombiner;

    public PhysicalDeviceFragmentShadingRatePropertiesKHR() { }
}
