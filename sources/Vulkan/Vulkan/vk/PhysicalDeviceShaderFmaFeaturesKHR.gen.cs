// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderFmaFeaturesKHR")]
public unsafe partial struct PhysicalDeviceShaderFmaFeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderFmaFeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderFmaFloat16")]
    public MaybeBool<uint> ShaderFmaFloat16;

    [NativeName("shaderFmaFloat32")]
    public MaybeBool<uint> ShaderFmaFloat32;

    [NativeName("shaderFmaFloat64")]
    public MaybeBool<uint> ShaderFmaFloat64;

    public PhysicalDeviceShaderFmaFeaturesKHR() { }
}
