// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3TessellationDomainOrigin;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3DepthClampEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3PolygonMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3RasterizationSamples;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3SampleMask;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3AlphaToCoverageEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3AlphaToOneEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3LogicOpEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ColorBlendEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ColorBlendEquation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ColorWriteMask;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3RasterizationStream;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ConservativeRasterizationMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ExtraPrimitiveOverestimationSize;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3DepthClipEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3SampleLocationsEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ColorBlendAdvanced;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ProvokingVertexMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3LineRasterizationMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3LineStippleEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3DepthClipNegativeOneToOne;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ViewportWScalingEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ViewportSwizzle;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageToColorEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageToColorLocation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageModulationMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageModulationTableEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageModulationTable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3CoverageReductionMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3RepresentativeFragmentTestEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_extended_dynamic_state3"],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ]
    )]
    public uint extendedDynamicState3ShadingRateImageEnable;
}
