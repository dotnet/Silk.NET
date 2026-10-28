// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineOpticalFlowCreateInfoARM")]
public unsafe partial struct DataGraphPipelineOpticalFlowCreateInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DataGraphPipelineOpticalFlowCreateInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("width")]
    public uint Width;

    [NativeName("height")]
    public uint Height;

    [NativeName("imageFormat")]
    public Format ImageFormat;

    [NativeName("flowVectorFormat")]
    public Format FlowVectorFormat;

    [NativeName("costFormat")]
    public Format CostFormat;

    [NativeName("outputGridSize")]
    public DataGraphOpticalFlowGridSizeFlagsARM OutputGridSize;

    [NativeName("hintGridSize")]
    public DataGraphOpticalFlowGridSizeFlagsARM HintGridSize;

    [NativeName("performanceLevel")]
    public DataGraphOpticalFlowPerformanceLevelARM PerformanceLevel;

    [NativeName("flags")]
    public DataGraphOpticalFlowCreateFlagsARM Flags;

    public DataGraphPipelineOpticalFlowCreateInfoARM() { }
}
