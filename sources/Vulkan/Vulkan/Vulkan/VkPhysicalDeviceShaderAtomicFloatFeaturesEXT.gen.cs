// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBufferFloat32Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBufferFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBufferFloat64Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderBufferFloat64AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderSharedFloat32Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderSharedFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderSharedFloat64Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint shaderSharedFloat64AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_atomic_float",
            "VkPhysicalDeviceShaderAtomicFloatFeaturesEXT::sparseImageFloat32Atomics",
        ],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public uint shaderImageFloat32Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_atomic_float",
            "VkPhysicalDeviceShaderAtomicFloatFeaturesEXT::sparseImageFloat32AtomicAdd",
        ],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public uint shaderImageFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint sparseImageFloat32Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float"],
        ImpliesSets = [
            "VK_EXT_shader_atomic_float+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_atomic_float+VK_VERSION_1_1",
        ]
    )]
    public uint sparseImageFloat32AtomicAdd;
}
