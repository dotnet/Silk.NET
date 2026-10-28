// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDepthStencilResolveProperties")]
public unsafe partial struct PhysicalDeviceDepthStencilResolveProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDepthStencilResolveProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("supportedDepthResolveModes")]
    public ResolveModeFlags SupportedDepthResolveModes;

    [NativeName("supportedStencilResolveModes")]
    public ResolveModeFlags SupportedStencilResolveModes;

    [NativeName("independentResolveNone")]
    public MaybeBool<uint> IndependentResolveNone;

    [NativeName("independentResolve")]
    public MaybeBool<uint> IndependentResolve;

    public PhysicalDeviceDepthStencilResolveProperties() { }
}
