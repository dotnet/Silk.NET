// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineFragmentShadingRateStateCreateInfoKHR")]
public unsafe partial struct PipelineFragmentShadingRateStateCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineFragmentShadingRateStateCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("fragmentSize")]
    public Extent2D FragmentSize;

    [NativeName("combinerOps")]
    public PipelineFragmentShadingRateStateCreateInfoKHRCombinerOps CombinerOps;

    public PipelineFragmentShadingRateStateCreateInfoKHR() { }
}
