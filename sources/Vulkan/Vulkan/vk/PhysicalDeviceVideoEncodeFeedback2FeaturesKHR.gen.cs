// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR")]
public unsafe partial struct PhysicalDeviceVideoEncodeFeedback2FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVideoEncodeFeedback2FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("videoEncodeFeedback2")]
    public MaybeBool<uint> VideoEncodeFeedback2;

    public PhysicalDeviceVideoEncodeFeedback2FeaturesKHR() { }
}
