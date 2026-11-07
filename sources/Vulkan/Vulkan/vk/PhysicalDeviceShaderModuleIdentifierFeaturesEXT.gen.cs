// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT")]
public unsafe partial struct PhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderModuleIdentifierFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderModuleIdentifier")]
    public MaybeBool<uint> ShaderModuleIdentifier;

    public PhysicalDeviceShaderModuleIdentifierFeaturesEXT() { }
}
