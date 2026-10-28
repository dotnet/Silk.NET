// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan14Features")]
public unsafe partial struct PhysicalDeviceVulkan14Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x4Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("globalPriorityQuery")]
    public MaybeBool<uint> GlobalPriorityQuery;

    [NativeName("shaderSubgroupRotate")]
    public MaybeBool<uint> ShaderSubgroupRotate;

    [NativeName("shaderSubgroupRotateClustered")]
    public MaybeBool<uint> ShaderSubgroupRotateClustered;

    [NativeName("shaderFloatControls2")]
    public MaybeBool<uint> ShaderFloatControls2;

    [NativeName("shaderExpectAssume")]
    public MaybeBool<uint> ShaderExpectAssume;

    [NativeName("rectangularLines")]
    public MaybeBool<uint> RectangularLines;

    [NativeName("bresenhamLines")]
    public MaybeBool<uint> BresenhamLines;

    [NativeName("smoothLines")]
    public MaybeBool<uint> SmoothLines;

    [NativeName("stippledRectangularLines")]
    public MaybeBool<uint> StippledRectangularLines;

    [NativeName("stippledBresenhamLines")]
    public MaybeBool<uint> StippledBresenhamLines;

    [NativeName("stippledSmoothLines")]
    public MaybeBool<uint> StippledSmoothLines;

    [NativeName("vertexAttributeInstanceRateDivisor")]
    public MaybeBool<uint> VertexAttributeInstanceRateDivisor;

    [NativeName("vertexAttributeInstanceRateZeroDivisor")]
    public MaybeBool<uint> VertexAttributeInstanceRateZeroDivisor;

    [NativeName("indexTypeUint8")]
    public MaybeBool<uint> IndexTypeUint8;

    [NativeName("dynamicRenderingLocalRead")]
    public MaybeBool<uint> DynamicRenderingLocalRead;

    [NativeName("maintenance5")]
    public MaybeBool<uint> Maintenance5;

    [NativeName("maintenance6")]
    public MaybeBool<uint> Maintenance6;

    [NativeName("pipelineProtectedAccess")]
    public MaybeBool<uint> PipelineProtectedAccess;

    [NativeName("pipelineRobustness")]
    public MaybeBool<uint> PipelineRobustness;

    [NativeName("hostImageCopy")]
    public MaybeBool<uint> HostImageCopy;

    [NativeName("pushDescriptor")]
    public MaybeBool<uint> PushDescriptor;

    public PhysicalDeviceVulkan14Features() { }
}
