// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderFloat16Int8Features")]
public unsafe partial struct PhysicalDeviceShaderFloat16Int8Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderFloat16Int8Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderFloat16")]
    public MaybeBool<uint> ShaderFloat16;

    [NativeName("shaderInt8")]
    public MaybeBool<uint> ShaderInt8;

    public PhysicalDeviceShaderFloat16Int8Features() { }
}
