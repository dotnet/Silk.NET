// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkPhysicalDeviceDataGraphOperationTypeARM")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPhysicalDeviceDataGraphOperationTypeARM : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_SPIRV_EXTENDED_INSTRUCTION_SET_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkPhysicalDeviceDataGraphOperationTypeSpirvExtendedInstructionSet = 0,

    [NativeName("VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_NEURAL_MODEL_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkPhysicalDeviceDataGraphOperationTypeNeuralModelQCOM = 1000629000,

    [NativeName("VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_BUILTIN_MODEL_QCOM")]
    [NameAffix("Suffix", "KhronosVendor", "QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_data_graph_model"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    VkPhysicalDeviceDataGraphOperationTypeBuiltinModelQCOM = 1000629001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_MAX_ENUM_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    VkPhysicalDeviceDataGraphOperationTypeMaxEnum = 0x7FFFFFFF,
}
