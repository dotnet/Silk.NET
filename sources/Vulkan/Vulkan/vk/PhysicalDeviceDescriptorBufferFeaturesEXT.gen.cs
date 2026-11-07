// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorBufferFeaturesEXT")]
public unsafe partial struct PhysicalDeviceDescriptorBufferFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorBufferFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("descriptorBuffer")]
    public MaybeBool<uint> DescriptorBuffer;

    [NativeName("descriptorBufferCaptureReplay")]
    public MaybeBool<uint> DescriptorBufferCaptureReplay;

    [NativeName("descriptorBufferImageLayoutIgnored")]
    public MaybeBool<uint> DescriptorBufferImageLayoutIgnored;

    [NativeName("descriptorBufferPushDescriptors")]
    public MaybeBool<uint> DescriptorBufferPushDescriptors;

    public PhysicalDeviceDescriptorBufferFeaturesEXT() { }
}
