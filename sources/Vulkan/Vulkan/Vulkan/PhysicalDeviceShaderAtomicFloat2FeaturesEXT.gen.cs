// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public void* PNext;

    [NativeName("shaderBufferFloat16Atomics")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderBufferFloat16Atomics;

    [NativeName("shaderBufferFloat16AtomicAdd")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderBufferFloat16AtomicAdd;

    [NativeName("shaderBufferFloat16AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderBufferFloat16AtomicMinMax;

    [NativeName("shaderBufferFloat32AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderBufferFloat32AtomicMinMax;

    [NativeName("shaderBufferFloat64AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderBufferFloat64AtomicMinMax;

    [NativeName("shaderSharedFloat16Atomics")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderSharedFloat16Atomics;

    [NativeName("shaderSharedFloat16AtomicAdd")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderSharedFloat16AtomicAdd;

    [NativeName("shaderSharedFloat16AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderSharedFloat16AtomicMinMax;

    [NativeName("shaderSharedFloat32AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderSharedFloat32AtomicMinMax;

    [NativeName("shaderSharedFloat64AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint ShaderSharedFloat64AtomicMinMax;

    [NativeName("shaderImageFloat32AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_atomic_float2",
            "VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT::sparseImageFloat32AtomicMinMax",
        ],
        ImpliesSets = ["VK_EXT_shader_atomic_float"],
        RequireAll = true
    )]
    public uint ShaderImageFloat32AtomicMinMax;

    [NativeName("sparseImageFloat32AtomicMinMax")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_atomic_float2"],
        ImpliesSets = ["VK_EXT_shader_atomic_float"]
    )]
    public uint SparseImageFloat32AtomicMinMax;
}
