// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum ComponentTypeKHR
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Float16KHR = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Float32KHR = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Float64KHR = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Sint8KHR = 3,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Sint16KHR = 4,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Sint32KHR = 5,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Sint64KHR = 6,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Uint8KHR = 7,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Uint16KHR = 8,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Uint32KHR = 9,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Uint64KHR = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix", "VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    Bfloat16KHR = 1000141000,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Sint8PackedNV = 1000491000,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    Uint8PackedNV = 1000491001,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    FloatE4M3NV = 1000491002,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    FloatE5M2NV = 1000491003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float16NV = Float16KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float32NV = Float32KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float64NV = Float64KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint8NV = Sint8KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint16NV = Sint16KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint32NV = Sint32KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint64NV = Sint64KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint8NV = Uint8KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint16NV = Uint16KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint32NV = Uint32KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint64NV = Uint64KHR,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    MaxEnumKHR = 0x7FFFFFFF,
}
