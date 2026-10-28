// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageFormatProperties")]
public partial struct ImageFormatProperties
{
    [NativeName("maxExtent")]
    public Extent3D MaxExtent;

    [NativeName("maxMipLevels")]
    public uint MaxMipLevels;

    [NativeName("maxArrayLayers")]
    public uint MaxArrayLayers;

    [NativeName("sampleCounts")]
    public SampleCountFlags SampleCounts;

    [NativeName("maxResourceSize")]
    public ulong MaxResourceSize;
}
