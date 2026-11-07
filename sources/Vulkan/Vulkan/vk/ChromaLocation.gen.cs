// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkChromaLocation")]
public enum ChromaLocation : uint
{
    [NativeName("VK_CHROMA_LOCATION_COSITED_EVEN")]
    CositedEven = 0,

    [NativeName("VK_CHROMA_LOCATION_MIDPOINT")]
    Midpoint = 1,

    [NativeName("VK_CHROMA_LOCATION_COSITED_EVEN_KHR")]
    CositedEvenKHR = CositedEven,

    [NativeName("VK_CHROMA_LOCATION_MIDPOINT_KHR")]
    MidpointKHR = Midpoint,
}
