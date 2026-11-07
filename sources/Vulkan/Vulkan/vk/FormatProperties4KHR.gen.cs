// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatProperties4KHR")]
public unsafe partial struct FormatProperties4KHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.FormatProperties4KHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("linearTilingFeatures")]
    public FormatFeatureFlags4KHR LinearTilingFeatures;

    [NativeName("optimalTilingFeatures")]
    public FormatFeatureFlags4KHR OptimalTilingFeatures;

    [NativeName("bufferFeatures")]
    public FormatFeatureFlags4KHR BufferFeatures;

    public FormatProperties4KHR() { }
}
