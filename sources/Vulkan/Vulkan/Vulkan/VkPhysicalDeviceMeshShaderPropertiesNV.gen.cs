// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMeshShaderPropertiesNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("maxDrawMeshTasksCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxDrawMeshTasksCount;

    [NativeName("maxTaskWorkGroupInvocations")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxTaskWorkGroupInvocations;

    [NativeName("maxTaskWorkGroupSize")]
    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public VkPhysicalDeviceMeshShaderPropertiesNVMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeName("maxTaskTotalMemorySize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxTaskTotalMemorySize;

    [NativeName("maxTaskOutputCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxTaskOutputCount;

    [NativeName("maxMeshWorkGroupInvocations")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxMeshWorkGroupInvocations;

    [NativeName("maxMeshWorkGroupSize")]
    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public VkPhysicalDeviceMeshShaderPropertiesNVMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeName("maxMeshTotalMemorySize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxMeshTotalMemorySize;

    [NativeName("maxMeshOutputVertices")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxMeshOutputVertices;

    [NativeName("maxMeshOutputPrimitives")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxMeshOutputPrimitives;

    [NativeName("maxMeshMultiviewViewCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MaxMeshMultiviewViewCount;

    [NativeName("meshOutputPerVertexGranularity")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MeshOutputPerVertexGranularity;

    [NativeName("meshOutputPerPrimitiveGranularity")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_NV_mesh_shader+VK_KHR_get_physical_device_properties2",
            "VK_NV_mesh_shader+VK_VERSION_1_1",
        ]
    )]
    public uint MeshOutputPerPrimitiveGranularity;
}
