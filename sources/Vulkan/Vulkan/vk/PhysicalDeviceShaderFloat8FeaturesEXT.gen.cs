// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderFloat8FeaturesEXT")]
public unsafe partial struct PhysicalDeviceShaderFloat8FeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderFloat8FeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderFloat8")]
    public MaybeBool<uint> ShaderFloat8;

    [NativeName("shaderFloat8CooperativeMatrix")]
    public MaybeBool<uint> ShaderFloat8CooperativeMatrix;

    public PhysicalDeviceShaderFloat8FeaturesEXT() { }
}
