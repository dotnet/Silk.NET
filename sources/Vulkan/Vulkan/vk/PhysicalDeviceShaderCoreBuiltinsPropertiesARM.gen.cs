// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM")]
public unsafe partial struct PhysicalDeviceShaderCoreBuiltinsPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderCoreBuiltinsPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderCoreMask")]
    public ulong ShaderCoreMask;

    [NativeName("shaderCoreCount")]
    public uint ShaderCoreCount;

    [NativeName("shaderWarpsPerCore")]
    public uint ShaderWarpsPerCore;

    public PhysicalDeviceShaderCoreBuiltinsPropertiesARM() { }
}
