// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance5Properties")]
public unsafe partial struct PhysicalDeviceMaintenance5Properties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance5Properties;

    [NativeName("pNext")]
    public void* PNext;

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

    public PhysicalDeviceMaintenance5Properties() { }
}
