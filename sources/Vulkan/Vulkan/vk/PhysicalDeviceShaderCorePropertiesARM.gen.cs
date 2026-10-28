// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderCorePropertiesARM")]
public unsafe partial struct PhysicalDeviceShaderCorePropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderCorePropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pixelRate")]
    public uint PixelRate;

    [NativeName("texelRate")]
    public uint TexelRate;

    [NativeName("fmaRate")]
    public uint FmaRate;

    public PhysicalDeviceShaderCorePropertiesARM() { }
}
