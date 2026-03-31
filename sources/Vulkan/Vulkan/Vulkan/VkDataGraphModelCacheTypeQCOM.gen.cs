// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "QCOM")]
[NativeName("VkDataGraphModelCacheTypeQCOM")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDataGraphModelCacheTypeQCOM : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_DATA_GRAPH_MODEL_CACHE_TYPE_GENERIC_BINARY_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkDataGraphModelCacheTypeGenericBinary = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_DATA_GRAPH_MODEL_CACHE_TYPE_MAX_ENUM_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkDataGraphModelCacheTypeMaxEnum = 0x7FFFFFFF,
}
