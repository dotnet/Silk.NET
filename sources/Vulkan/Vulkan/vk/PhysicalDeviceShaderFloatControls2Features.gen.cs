// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderFloatControls2Features")]
public unsafe partial struct PhysicalDeviceShaderFloatControls2Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderFloatControls2Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderFloatControls2")]
    public MaybeBool<uint> ShaderFloatControls2;

    public PhysicalDeviceShaderFloatControls2Features() { }
}
