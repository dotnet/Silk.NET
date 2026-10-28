// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT")]
public unsafe partial struct PhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("advancedBlendMaxColorAttachments")]
    public uint AdvancedBlendMaxColorAttachments;

    [NativeName("advancedBlendIndependentBlend")]
    public MaybeBool<uint> AdvancedBlendIndependentBlend;

    [NativeName("advancedBlendNonPremultipliedSrcColor")]
    public MaybeBool<uint> AdvancedBlendNonPremultipliedSrcColor;

    [NativeName("advancedBlendNonPremultipliedDstColor")]
    public MaybeBool<uint> AdvancedBlendNonPremultipliedDstColor;

    [NativeName("advancedBlendCorrelatedOverlap")]
    public MaybeBool<uint> AdvancedBlendCorrelatedOverlap;

    [NativeName("advancedBlendAllOperations")]
    public MaybeBool<uint> AdvancedBlendAllOperations;

    public PhysicalDeviceBlendOperationAdvancedPropertiesEXT() { }
}
