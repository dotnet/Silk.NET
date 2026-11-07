// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDepthBiasControlFeaturesEXT")]
public unsafe partial struct PhysicalDeviceDepthBiasControlFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDepthBiasControlFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("depthBiasControl")]
    public MaybeBool<uint> DepthBiasControl;

    [NativeName("leastRepresentableValueForceUnormRepresentation")]
    public MaybeBool<uint> LeastRepresentableValueForceUnormRepresentation;

    [NativeName("floatRepresentation")]
    public MaybeBool<uint> FloatRepresentation;

    [NativeName("depthBiasExact")]
    public MaybeBool<uint> DepthBiasExact;

    public PhysicalDeviceDepthBiasControlFeaturesEXT() { }
}
