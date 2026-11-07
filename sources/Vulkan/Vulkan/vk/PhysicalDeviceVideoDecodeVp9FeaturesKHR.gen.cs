// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVideoDecodeVP9FeaturesKHR")]
public unsafe partial struct PhysicalDeviceVideoDecodeVp9FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVideoDecodeVp9FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("videoDecodeVP9")]
    public MaybeBool<uint> VideoDecodeVp9;

    public PhysicalDeviceVideoDecodeVp9FeaturesKHR() { }
}
