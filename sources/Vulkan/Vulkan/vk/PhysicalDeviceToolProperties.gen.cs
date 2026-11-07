// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceToolProperties")]
public unsafe partial struct PhysicalDeviceToolProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceToolProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("name")]
    public PhysicalDeviceToolPropertiesName Name;

    [NativeName("version")]
    public PhysicalDeviceToolPropertiesVersion Version;

    [NativeName("purposes")]
    public ToolPurposeFlags Purposes;

    [NativeName("description")]
    public PhysicalDeviceToolPropertiesDescription Description;

    [NativeName("layer")]
    public PhysicalDeviceToolPropertiesLayer Layer;

    public PhysicalDeviceToolProperties() { }
}
