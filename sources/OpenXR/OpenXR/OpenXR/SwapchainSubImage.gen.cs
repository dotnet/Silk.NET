// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainSubImage")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainSubImage
{
    [NativeName("swapchain")]
    [SupportedApiProfile("openxr")]
    public SwapchainHandle Swapchain;

    [NativeName("imageRect")]
    [SupportedApiProfile("openxr")]
    public Rect2Di ImageRect;

    [NativeName("imageArrayIndex")]
    [SupportedApiProfile("openxr")]
    public uint ImageArrayIndex;
}
