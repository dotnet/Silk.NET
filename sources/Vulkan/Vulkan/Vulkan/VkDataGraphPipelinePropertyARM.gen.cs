// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkDataGraphPipelinePropertyARM")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDataGraphPipelinePropertyARM : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkDataGraphPipelinePropertyCreationLog = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkDataGraphPipelinePropertyIdentifier = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_DATA_GRAPH_PIPELINE_PROPERTY_MAX_ENUM_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkDataGraphPipelinePropertyMaxEnum = 0x7FFFFFFF,
}
