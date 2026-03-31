// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineBuiltinModelCreateInfoQCOM")]
[NameAffix("Suffix", "KhronosVendor", "QCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDataGraphPipelineBuiltinModelCreateInfoQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public void* PNext;

    [NativeName("pOperation")]
    [NativeTypeName("const VkPhysicalDeviceDataGraphOperationSupportARM *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public VkPhysicalDeviceDataGraphOperationSupportARM* POperation;
}
