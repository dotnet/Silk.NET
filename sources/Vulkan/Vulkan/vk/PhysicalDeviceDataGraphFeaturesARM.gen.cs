// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDataGraphFeaturesARM")]
public unsafe partial struct PhysicalDeviceDataGraphFeaturesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDataGraphFeaturesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("dataGraph")]
    public MaybeBool<uint> DataGraph;

    [NativeName("dataGraphUpdateAfterBind")]
    public MaybeBool<uint> DataGraphUpdateAfterBind;

    [NativeName("dataGraphSpecializationConstants")]
    public MaybeBool<uint> DataGraphSpecializationConstants;

    [NativeName("dataGraphDescriptorBuffer")]
    public MaybeBool<uint> DataGraphDescriptorBuffer;

    [NativeName("dataGraphShaderModule")]
    public MaybeBool<uint> DataGraphShaderModule;

    public PhysicalDeviceDataGraphFeaturesARM() { }
}
