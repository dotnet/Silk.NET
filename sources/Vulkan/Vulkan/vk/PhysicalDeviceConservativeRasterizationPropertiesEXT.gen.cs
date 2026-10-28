// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceConservativeRasterizationPropertiesEXT")]
public unsafe partial struct PhysicalDeviceConservativeRasterizationPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("primitiveOverestimationSize")]
    public float PrimitiveOverestimationSize;

    [NativeName("maxExtraPrimitiveOverestimationSize")]
    public float MaxExtraPrimitiveOverestimationSize;

    [NativeName("extraPrimitiveOverestimationSizeGranularity")]
    public float ExtraPrimitiveOverestimationSizeGranularity;

    [NativeName("primitiveUnderestimation")]
    public MaybeBool<uint> PrimitiveUnderestimation;

    [NativeName("conservativePointAndLineRasterization")]
    public MaybeBool<uint> ConservativePointAndLineRasterization;

    [NativeName("degenerateTrianglesRasterized")]
    public MaybeBool<uint> DegenerateTrianglesRasterized;

    [NativeName("degenerateLinesRasterized")]
    public MaybeBool<uint> DegenerateLinesRasterized;

    [NativeName("fullyCoveredFragmentShaderInputVariable")]
    public MaybeBool<uint> FullyCoveredFragmentShaderInputVariable;

    [NativeName("conservativeRasterizationPostDepthCoverage")]
    public MaybeBool<uint> ConservativeRasterizationPostDepthCoverage;

    public PhysicalDeviceConservativeRasterizationPropertiesEXT() { }
}
