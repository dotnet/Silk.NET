// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderImageInt64Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_image_atomic_int64"],
        ImpliesSets = [
            "VK_EXT_shader_image_atomic_int64+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_image_atomic_int64+VK_VERSION_1_1",
        ]
    )]
    public uint SparseImageInt64Atomics;
}
