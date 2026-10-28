// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT")]
public unsafe partial struct PhysicalDeviceRgba10x6FormatsFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRgba10x6FormatsFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("formatRgba10x6WithoutYCbCrSampler")]
    public MaybeBool<uint> FormatRgba10x6WithoutYCbCrSampler;

    public PhysicalDeviceRgba10x6FormatsFeaturesEXT() { }
}
