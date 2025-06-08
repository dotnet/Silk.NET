// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceTileShadingFeaturesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShading;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingFragmentStage;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingColorAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingDepthAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingStencilAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingInputAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingSampledAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingPerTileDraw;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingPerTileDispatch;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingDispatchTile;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingApron;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingAnisotropicApron;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingAtomicOps;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_shading"],
        ImpliesSets = [
            "VK_QCOM_tile_shading+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_shading+VK_QCOM_tile_properties",
        ]
    )]
    public uint tileShadingImageProcessing;
}
