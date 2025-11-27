// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("QCOM", 0)]
[NativeName("VkPipelineCacheHeaderVersionDataGraphQCOM")]
[SupportedApiProfile("vulkan")]
public partial struct PipelineCacheHeaderVersionDataGraphQCOM
{
    [NativeName("headerSize")]
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
    public PipelineCacheHeaderVersion HeaderVersion;

    [NativeName("cacheType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphModelCacheTypeQCOM CacheType;

    [NativeName("cacheVersion")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public uint CacheVersion;

    [NativeName("toolchainVersion")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public PipelineCacheHeaderVersionDataGraphQCOMToolchainVersion ToolchainVersion;
}
