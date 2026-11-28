// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VK_LOADER_DATA")]
[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct LoaderData
{
    [NativeName("loaderMagic")]
    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public nuint LoaderMagic;

    [NativeName("loaderData")]
    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public void* PLoaderData;
}
