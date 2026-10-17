// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingVulkanKHR")]
public unsafe partial struct GraphicsBindingVulkanKHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.GraphicsBindingVulkanKHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("instance")]
    public VkInstanceHandle Instance;

    [NativeName("physicalDevice")]
    public VkPhysicalDeviceHandle PhysicalDevice;

    [NativeName("device")]
    public VkDeviceHandle Device;

    [NativeName("queueFamilyIndex")]
    public uint QueueFamilyIndex;

    [NativeName("queueIndex")]
    public uint QueueIndex;

    public GraphicsBindingVulkanKHR() { }
}
