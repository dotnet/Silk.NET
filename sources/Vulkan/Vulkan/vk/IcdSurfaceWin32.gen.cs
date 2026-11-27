// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIcdSurfaceWin32")]
[SupportedApiProfile("vulkan")]
public partial struct IcdSurfaceWin32
{
    [NativeName("@base")]
    [SupportedApiProfile("vulkan")]
    public IcdSurfaceBase @base;

    [NativeName("hinstance")]
    [SupportedApiProfile("vulkan")]
    public void Hinstance;

    [NativeName("hwnd")]
    [SupportedApiProfile("vulkan")]
    public void Hwnd;
}
