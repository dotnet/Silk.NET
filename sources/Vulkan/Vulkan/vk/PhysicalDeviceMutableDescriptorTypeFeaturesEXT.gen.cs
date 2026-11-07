// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT")]
public unsafe partial struct PhysicalDeviceMutableDescriptorTypeFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMutableDescriptorTypeFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("mutableDescriptorType")]
    public MaybeBool<uint> MutableDescriptorType;

    public PhysicalDeviceMutableDescriptorTypeFeaturesEXT() { }
}
