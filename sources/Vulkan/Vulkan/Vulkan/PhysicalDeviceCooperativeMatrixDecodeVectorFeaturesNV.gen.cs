// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix_decode_vector"],
        ImpliesSets = ["VK_NV_cooperative_matrix2"]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix_decode_vector"],
        ImpliesSets = ["VK_NV_cooperative_matrix2"]
    )]
    public void* PNext;

    [NativeName("cooperativeMatrixDecodeVector")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix_decode_vector"],
        ImpliesSets = ["VK_NV_cooperative_matrix2"]
    )]
    public MaybeBool<uint> CooperativeMatrixDecodeVector;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix_decode_vector"],
        ImpliesSets = ["VK_NV_cooperative_matrix2"]
    )]
    public PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV() { }
}
