// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageStencilUsage2CreateInfoKHR")]
public unsafe partial struct ImageStencilUsage2CreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImageStencilUsage2CreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stencilUsage")]
    public ImageUsageFlags2KHR StencilUsage;

    public ImageStencilUsage2CreateInfoKHR() { }
}
