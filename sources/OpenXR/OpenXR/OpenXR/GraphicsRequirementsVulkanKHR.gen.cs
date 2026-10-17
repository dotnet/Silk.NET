// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsRequirementsVulkanKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsRequirementsVulkanKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public StructureType Type = StructureType.GraphicsRequirementsVulkanKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public void* Next;

    [NativeName("minApiVersionSupported")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public ulong MinApiVersionSupported;

    [NativeName("maxApiVersionSupported")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public ulong MaxApiVersionSupported;

    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public GraphicsRequirementsVulkanKHR() { }
}
