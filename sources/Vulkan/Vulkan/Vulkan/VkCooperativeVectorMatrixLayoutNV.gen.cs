// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkCooperativeVectorMatrixLayoutNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCooperativeVectorMatrixLayoutNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkCooperativeVectorMatrixLayoutRowMajor = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkCooperativeVectorMatrixLayoutColumnMajor = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkCooperativeVectorMatrixLayoutInferencingOptimal = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkCooperativeVectorMatrixLayoutTrainingOptimal = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkCooperativeVectorMatrixLayoutMaxEnum = 0x7FFFFFFF,
}
