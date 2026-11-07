// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubresourceLayout2")]
public unsafe partial struct SubresourceLayout2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubresourceLayout2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("subresourceLayout")]
    public SubresourceLayout SubresourceLayout;

    public SubresourceLayout2() { }
}
