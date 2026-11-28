// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_u_e__Union")]
[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct LayerDeviceCreateInfoU
{
    [NativeName("pLayerInfo")]
    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public LayerDeviceLink* PLayerInfo;

    [NativeName("pfnSetDeviceLoaderData")]
    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public SetDeviceLoaderData PfnSetDeviceLoaderData;
}
