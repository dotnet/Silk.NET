// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderBfloat16FeaturesKHR")]
public unsafe partial struct PhysicalDeviceShaderBfloat16FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderBfloat16FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderBFloat16Type")]
    public MaybeBool<uint> ShaderBFloat16Type;

    [NativeName("shaderBFloat16DotProduct")]
    public MaybeBool<uint> ShaderBFloat16DotProduct;

    [NativeName("shaderBFloat16CooperativeMatrix")]
    public MaybeBool<uint> ShaderBFloat16CooperativeMatrix;

    public PhysicalDeviceShaderBfloat16FeaturesKHR() { }
}
