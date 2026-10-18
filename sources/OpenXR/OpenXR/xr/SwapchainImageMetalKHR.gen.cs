// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainImageMetalKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainImageMetalKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    public StructureType Type = StructureType.SwapchainImageMetalKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    public void* Next;

    [NativeName("texture")]
    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    public void* Texture;

    [SupportedApiProfile("openxr", ["XR_KHR_metal_enable"])]
    public SwapchainImageMetalKHR() { }
}
