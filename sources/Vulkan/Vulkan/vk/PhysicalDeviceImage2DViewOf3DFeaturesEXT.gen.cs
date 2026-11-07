// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImage2DViewOf3DFeaturesEXT")]
public unsafe partial struct PhysicalDeviceImage2DViewOf3DFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceImage2DViewOf3DFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("image2DViewOf3D")]
    public MaybeBool<uint> Image2DViewOf3D;

    [NativeName("sampler2DViewOf3D")]
    public MaybeBool<uint> Sampler2DViewOf3D;

    public PhysicalDeviceImage2DViewOf3DFeaturesEXT() { }
}
