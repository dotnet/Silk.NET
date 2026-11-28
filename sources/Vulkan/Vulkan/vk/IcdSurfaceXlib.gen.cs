// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIcdSurfaceXlib")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct IcdSurfaceXlib
{
    [NativeName("@base")]
    [SupportedApiProfile("vulkan")]
    public IcdSurfaceBase @base;

    [NativeName("dpy")]
    [SupportedApiProfile("vulkan")]
    public void* Dpy;

    [NativeName("window")]
    [SupportedApiProfile("vulkan")]
    public nuint Window;
}
