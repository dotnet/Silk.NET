// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance7PropertiesKHR")]
public unsafe partial struct PhysicalDeviceMaintenance7PropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance7PropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("robustFragmentShadingRateAttachmentAccess")]
    public MaybeBool<uint> RobustFragmentShadingRateAttachmentAccess;

    [NativeName("separateDepthStencilAttachmentAccess")]
    public MaybeBool<uint> SeparateDepthStencilAttachmentAccess;

    [NativeName("maxDescriptorSetTotalUniformBuffersDynamic")]
    public uint MaxDescriptorSetTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetTotalStorageBuffersDynamic")]
    public uint MaxDescriptorSetTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetTotalBuffersDynamic")]
    public uint MaxDescriptorSetTotalBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindTotalBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;

    public PhysicalDeviceMaintenance7PropertiesKHR() { }
}
