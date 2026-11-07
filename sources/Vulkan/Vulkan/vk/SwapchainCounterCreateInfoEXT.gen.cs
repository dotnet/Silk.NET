// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainCounterCreateInfoEXT")]
public unsafe partial struct SwapchainCounterCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SwapchainCounterCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("surfaceCounters")]
    public SurfaceCounterFlagsEXT SurfaceCounters;

    public SwapchainCounterCreateInfoEXT() { }
}
