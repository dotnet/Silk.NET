// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT")]
public unsafe partial struct PhysicalDeviceImageSlicedViewOf3DFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceImageSlicedViewOf3DFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("imageSlicedViewOf3D")]
    public MaybeBool<uint> ImageSlicedViewOf3D;

    public PhysicalDeviceImageSlicedViewOf3DFeaturesEXT() { }
}
