// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVideoEncodeAV1FeaturesKHR")]
public unsafe partial struct PhysicalDeviceVideoEncodeAv1FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVideoEncodeAv1FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("videoEncodeAV1")]
    public MaybeBool<uint> VideoEncodeAv1;

    public PhysicalDeviceVideoEncodeAv1FeaturesKHR() { }
}
