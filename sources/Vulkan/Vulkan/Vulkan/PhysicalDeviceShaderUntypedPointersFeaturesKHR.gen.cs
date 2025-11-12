// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderUntypedPointersFeaturesKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_untyped_pointers"],
        ImpliesSets = ["VK_KHR_get_physical_device_properties2"]
    )]
    public MaybeBool<uint> ShaderUntypedPointers;
}
