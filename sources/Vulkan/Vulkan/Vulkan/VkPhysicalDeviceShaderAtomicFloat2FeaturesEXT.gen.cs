// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderBufferFloat16Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderBufferFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderBufferFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderBufferFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderBufferFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderSharedFloat16Atomics;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderSharedFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderSharedFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderSharedFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint shaderSharedFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_atomic_float2",
            "VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT::sparseImageFloat32AtomicMinMax",
        ],
        ImpliesSets = ["VK_EXT_shader_atomic_float"],
        RequireAll = true
    )]
    public uint shaderImageFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint sparseImageFloat32AtomicMinMax;
}
