// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_cooperative_matrix_conversion"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_cooperative_matrix_conversion"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public void* PNext;

    [NativeName("cooperativeMatrixConversion")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_cooperative_matrix_conversion"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixConversion;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_cooperative_matrix_conversion"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM() { }
}
