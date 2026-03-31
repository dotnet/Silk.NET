// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCacheHeaderVersionDataGraphQCOM")]
[NameAffix("Suffix", "KhronosVendor", "QCOM")]
[SupportedApiProfile("vulkan")]
public partial struct VkPipelineCacheHeaderVersionDataGraphQCOM
{
    [NativeName("headerSize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public uint HeaderSize;

    [NativeName("headerVersion")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public VkPipelineCacheHeaderVersion HeaderVersion;

    [NativeName("cacheType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public VkDataGraphModelCacheTypeQCOM CacheType;

    [NativeName("cacheVersion")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public uint CacheVersion;

    [NativeName("toolchainVersion")]
    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public VkPipelineCacheHeaderVersionDataGraphQCOMToolchainVersion ToolchainVersion;
}
