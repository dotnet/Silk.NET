// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance9PropertiesKHR")]
public unsafe partial struct PhysicalDeviceMaintenance9PropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance9PropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("image2DViewOf3DSparse")]
    public MaybeBool<uint> Image2DViewOf3DSparse;

    [NativeName("defaultVertexAttributeValue")]
    public DefaultVertexAttributeValueKHR DefaultVertexAttributeValue;

    public PhysicalDeviceMaintenance9PropertiesKHR() { }
}
