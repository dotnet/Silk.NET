// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPropertiesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDisplayPropertiesKHR
{
    [NativeName("display")]
    [NativeTypeName("VkDisplayKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkDisplayHandleKHR Display;

    [NativeName("displayName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public sbyte* DisplayName;

    [NativeName("physicalDimensions")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D PhysicalDimensions;

    [NativeName("physicalResolution")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D PhysicalResolution;

    [NativeName("supportedTransforms")]
    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR SupportedTransforms;

    [NativeName("planeReorderPossible")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PlaneReorderPossible;

    [NativeName("persistentContent")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PersistentContent;
}
