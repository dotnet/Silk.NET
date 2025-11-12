// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_representative_fragment_test"],
        ImpliesSets = [
            "VK_NV_representative_fragment_test+VK_KHR_get_physical_device_properties2",
            "VK_NV_representative_fragment_test+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> RepresentativeFragmentTest;
}
