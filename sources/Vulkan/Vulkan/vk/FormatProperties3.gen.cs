// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatProperties3")]
public unsafe partial struct FormatProperties3
{
    [NativeName("sType")]
    public StructureType SType = StructureType.FormatProperties3;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("linearTilingFeatures")]
    public FormatFeatureFlags2 LinearTilingFeatures;

    [NativeName("optimalTilingFeatures")]
    public FormatFeatureFlags2 OptimalTilingFeatures;

    [NativeName("bufferFeatures")]
    public FormatFeatureFlags2 BufferFeatures;

    public FormatProperties3() { }
}
