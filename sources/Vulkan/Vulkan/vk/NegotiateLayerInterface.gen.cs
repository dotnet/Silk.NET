// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkNegotiateLayerInterface")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct NegotiateLayerInterface
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan")]
    public NegotiateLayerStructType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeName("loaderLayerInterfaceVersion")]
    [SupportedApiProfile("vulkan")]
    public uint LoaderLayerInterfaceVersion;

    [NativeName("pfnGetInstanceProcAddr")]
    [SupportedApiProfile("vulkan")]
    public GetInstanceProcAddr PfnGetInstanceProcAddr;

    [NativeName("pfnGetDeviceProcAddr")]
    [SupportedApiProfile("vulkan")]
    public GetDeviceProcAddr PfnGetDeviceProcAddr;

    [NativeName("pfnGetPhysicalDeviceProcAddr")]
    [SupportedApiProfile("vulkan")]
    public PfnGetPhysicalDeviceProcAddr PfnGetPhysicalDeviceProcAddr;
}
