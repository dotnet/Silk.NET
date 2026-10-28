// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceExtendedDynamicState3FeaturesEXT")]
public unsafe partial struct PhysicalDeviceExtendedDynamicState3FeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceExtendedDynamicState3FeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("extendedDynamicState3TessellationDomainOrigin")]
    public MaybeBool<uint> ExtendedDynamicState3TessellationDomainOrigin;

    [NativeName("extendedDynamicState3DepthClampEnable")]
    public MaybeBool<uint> ExtendedDynamicState3DepthClampEnable;

    [NativeName("extendedDynamicState3PolygonMode")]
    public MaybeBool<uint> ExtendedDynamicState3PolygonMode;

    [NativeName("extendedDynamicState3RasterizationSamples")]
    public MaybeBool<uint> ExtendedDynamicState3RasterizationSamples;

    [NativeName("extendedDynamicState3SampleMask")]
    public MaybeBool<uint> ExtendedDynamicState3SampleMask;

    [NativeName("extendedDynamicState3AlphaToCoverageEnable")]
    public MaybeBool<uint> ExtendedDynamicState3AlphaToCoverageEnable;

    [NativeName("extendedDynamicState3AlphaToOneEnable")]
    public MaybeBool<uint> ExtendedDynamicState3AlphaToOneEnable;

    [NativeName("extendedDynamicState3LogicOpEnable")]
    public MaybeBool<uint> ExtendedDynamicState3LogicOpEnable;

    [NativeName("extendedDynamicState3ColorBlendEnable")]
    public MaybeBool<uint> ExtendedDynamicState3ColorBlendEnable;

    [NativeName("extendedDynamicState3ColorBlendEquation")]
    public MaybeBool<uint> ExtendedDynamicState3ColorBlendEquation;

    [NativeName("extendedDynamicState3ColorWriteMask")]
    public MaybeBool<uint> ExtendedDynamicState3ColorWriteMask;

    [NativeName("extendedDynamicState3RasterizationStream")]
    public MaybeBool<uint> ExtendedDynamicState3RasterizationStream;

    [NativeName("extendedDynamicState3ConservativeRasterizationMode")]
    public MaybeBool<uint> ExtendedDynamicState3ConservativeRasterizationMode;

    [NativeName("extendedDynamicState3ExtraPrimitiveOverestimationSize")]
    public MaybeBool<uint> ExtendedDynamicState3ExtraPrimitiveOverestimationSize;

    [NativeName("extendedDynamicState3DepthClipEnable")]
    public MaybeBool<uint> ExtendedDynamicState3DepthClipEnable;

    [NativeName("extendedDynamicState3SampleLocationsEnable")]
    public MaybeBool<uint> ExtendedDynamicState3SampleLocationsEnable;

    [NativeName("extendedDynamicState3ColorBlendAdvanced")]
    public MaybeBool<uint> ExtendedDynamicState3ColorBlendAdvanced;

    [NativeName("extendedDynamicState3ProvokingVertexMode")]
    public MaybeBool<uint> ExtendedDynamicState3ProvokingVertexMode;

    [NativeName("extendedDynamicState3LineRasterizationMode")]
    public MaybeBool<uint> ExtendedDynamicState3LineRasterizationMode;

    [NativeName("extendedDynamicState3LineStippleEnable")]
    public MaybeBool<uint> ExtendedDynamicState3LineStippleEnable;

    [NativeName("extendedDynamicState3DepthClipNegativeOneToOne")]
    public MaybeBool<uint> ExtendedDynamicState3DepthClipNegativeOneToOne;

    [NativeName("extendedDynamicState3ViewportWScalingEnable")]
    public MaybeBool<uint> ExtendedDynamicState3ViewportWScalingEnable;

    [NativeName("extendedDynamicState3ViewportSwizzle")]
    public MaybeBool<uint> ExtendedDynamicState3ViewportSwizzle;

    [NativeName("extendedDynamicState3CoverageToColorEnable")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageToColorEnable;

    [NativeName("extendedDynamicState3CoverageToColorLocation")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageToColorLocation;

    [NativeName("extendedDynamicState3CoverageModulationMode")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageModulationMode;

    [NativeName("extendedDynamicState3CoverageModulationTableEnable")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageModulationTableEnable;

    [NativeName("extendedDynamicState3CoverageModulationTable")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageModulationTable;

    [NativeName("extendedDynamicState3CoverageReductionMode")]
    public MaybeBool<uint> ExtendedDynamicState3CoverageReductionMode;

    [NativeName("extendedDynamicState3RepresentativeFragmentTestEnable")]
    public MaybeBool<uint> ExtendedDynamicState3RepresentativeFragmentTestEnable;

    [NativeName("extendedDynamicState3ShadingRateImageEnable")]
    public MaybeBool<uint> ExtendedDynamicState3ShadingRateImageEnable;

    public PhysicalDeviceExtendedDynamicState3FeaturesEXT() { }
}
