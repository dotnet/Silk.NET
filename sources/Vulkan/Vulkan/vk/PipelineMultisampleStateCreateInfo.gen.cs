// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineMultisampleStateCreateInfo")]
public unsafe partial struct PipelineMultisampleStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineMultisampleStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("rasterizationSamples")]
    public SampleCountFlags RasterizationSamples;

    [NativeName("sampleShadingEnable")]
    public MaybeBool<uint> SampleShadingEnable;

    [NativeName("minSampleShading")]
    public float MinSampleShading;

    [NativeName("pSampleMask")]
    public uint* PSampleMask;

    [NativeName("alphaToCoverageEnable")]
    public MaybeBool<uint> AlphaToCoverageEnable;

    [NativeName("alphaToOneEnable")]
    public MaybeBool<uint> AlphaToOneEnable;

    public PipelineMultisampleStateCreateInfo() { }
}
