// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormat")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkFormat : uint
{
    [NativeName("VK_FORMAT_UNDEFINED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatUndefined = 0,

    [NativeName("VK_FORMAT_R4G4_UNORM_PACK8")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR4G4UnormPack8 = 1,

    [NativeName("VK_FORMAT_R4G4B4A4_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR4G4B4A4UnormPack16 = 2,

    [NativeName("VK_FORMAT_B4G4R4A4_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB4G4R4A4UnormPack16 = 3,

    [NativeName("VK_FORMAT_R5G6B5_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR5G6B5UnormPack16 = 4,

    [NativeName("VK_FORMAT_B5G6R5_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB5G6R5UnormPack16 = 5,

    [NativeName("VK_FORMAT_R5G5B5A1_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR5G5B5A1UnormPack16 = 6,

    [NativeName("VK_FORMAT_B5G5R5A1_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB5G5R5A1UnormPack16 = 7,

    [NativeName("VK_FORMAT_A1R5G5B5_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA1R5G5B5UnormPack16 = 8,

    [NativeName("VK_FORMAT_R8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Unorm = 9,

    [NativeName("VK_FORMAT_R8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Snorm = 10,

    [NativeName("VK_FORMAT_R8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Uscaled = 11,

    [NativeName("VK_FORMAT_R8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Sscaled = 12,

    [NativeName("VK_FORMAT_R8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Uint = 13,

    [NativeName("VK_FORMAT_R8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Sint = 14,

    [NativeName("VK_FORMAT_R8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8Srgb = 15,

    [NativeName("VK_FORMAT_R8G8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Unorm = 16,

    [NativeName("VK_FORMAT_R8G8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Snorm = 17,

    [NativeName("VK_FORMAT_R8G8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Uscaled = 18,

    [NativeName("VK_FORMAT_R8G8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Sscaled = 19,

    [NativeName("VK_FORMAT_R8G8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Uint = 20,

    [NativeName("VK_FORMAT_R8G8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Sint = 21,

    [NativeName("VK_FORMAT_R8G8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8Srgb = 22,

    [NativeName("VK_FORMAT_R8G8B8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Unorm = 23,

    [NativeName("VK_FORMAT_R8G8B8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Snorm = 24,

    [NativeName("VK_FORMAT_R8G8B8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Uscaled = 25,

    [NativeName("VK_FORMAT_R8G8B8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Sscaled = 26,

    [NativeName("VK_FORMAT_R8G8B8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Uint = 27,

    [NativeName("VK_FORMAT_R8G8B8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Sint = 28,

    [NativeName("VK_FORMAT_R8G8B8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8Srgb = 29,

    [NativeName("VK_FORMAT_B8G8R8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Unorm = 30,

    [NativeName("VK_FORMAT_B8G8R8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Snorm = 31,

    [NativeName("VK_FORMAT_B8G8R8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Uscaled = 32,

    [NativeName("VK_FORMAT_B8G8R8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Sscaled = 33,

    [NativeName("VK_FORMAT_B8G8R8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Uint = 34,

    [NativeName("VK_FORMAT_B8G8R8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Sint = 35,

    [NativeName("VK_FORMAT_B8G8R8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8Srgb = 36,

    [NativeName("VK_FORMAT_R8G8B8A8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Unorm = 37,

    [NativeName("VK_FORMAT_R8G8B8A8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Snorm = 38,

    [NativeName("VK_FORMAT_R8G8B8A8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Uscaled = 39,

    [NativeName("VK_FORMAT_R8G8B8A8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Sscaled = 40,

    [NativeName("VK_FORMAT_R8G8B8A8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Uint = 41,

    [NativeName("VK_FORMAT_R8G8B8A8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Sint = 42,

    [NativeName("VK_FORMAT_R8G8B8A8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR8G8B8A8Srgb = 43,

    [NativeName("VK_FORMAT_B8G8R8A8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Unorm = 44,

    [NativeName("VK_FORMAT_B8G8R8A8_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Snorm = 45,

    [NativeName("VK_FORMAT_B8G8R8A8_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Uscaled = 46,

    [NativeName("VK_FORMAT_B8G8R8A8_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Sscaled = 47,

    [NativeName("VK_FORMAT_B8G8R8A8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Uint = 48,

    [NativeName("VK_FORMAT_B8G8R8A8_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Sint = 49,

    [NativeName("VK_FORMAT_B8G8R8A8_SRGB")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB8G8R8A8Srgb = 50,

    [NativeName("VK_FORMAT_A8B8G8R8_UNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8UnormPack32 = 51,

    [NativeName("VK_FORMAT_A8B8G8R8_SNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8SnormPack32 = 52,

    [NativeName("VK_FORMAT_A8B8G8R8_USCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8UscaledPack32 = 53,

    [NativeName("VK_FORMAT_A8B8G8R8_SSCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8SscaledPack32 = 54,

    [NativeName("VK_FORMAT_A8B8G8R8_UINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8UintPack32 = 55,

    [NativeName("VK_FORMAT_A8B8G8R8_SINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8SintPack32 = 56,

    [NativeName("VK_FORMAT_A8B8G8R8_SRGB_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA8B8G8R8SrgbPack32 = 57,

    [NativeName("VK_FORMAT_A2R10G10B10_UNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10UnormPack32 = 58,

    [NativeName("VK_FORMAT_A2R10G10B10_SNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10SnormPack32 = 59,

    [NativeName("VK_FORMAT_A2R10G10B10_USCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10UscaledPack32 = 60,

    [NativeName("VK_FORMAT_A2R10G10B10_SSCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10SscaledPack32 = 61,

    [NativeName("VK_FORMAT_A2R10G10B10_UINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10UintPack32 = 62,

    [NativeName("VK_FORMAT_A2R10G10B10_SINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2R10G10B10SintPack32 = 63,

    [NativeName("VK_FORMAT_A2B10G10R10_UNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10UnormPack32 = 64,

    [NativeName("VK_FORMAT_A2B10G10R10_SNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10SnormPack32 = 65,

    [NativeName("VK_FORMAT_A2B10G10R10_USCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10UscaledPack32 = 66,

    [NativeName("VK_FORMAT_A2B10G10R10_SSCALED_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10SscaledPack32 = 67,

    [NativeName("VK_FORMAT_A2B10G10R10_UINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10UintPack32 = 68,

    [NativeName("VK_FORMAT_A2B10G10R10_SINT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatA2B10G10R10SintPack32 = 69,

    [NativeName("VK_FORMAT_R16_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Unorm = 70,

    [NativeName("VK_FORMAT_R16_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Snorm = 71,

    [NativeName("VK_FORMAT_R16_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Uscaled = 72,

    [NativeName("VK_FORMAT_R16_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Sscaled = 73,

    [NativeName("VK_FORMAT_R16_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Uint = 74,

    [NativeName("VK_FORMAT_R16_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Sint = 75,

    [NativeName("VK_FORMAT_R16_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16Sfloat = 76,

    [NativeName("VK_FORMAT_R16G16_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Unorm = 77,

    [NativeName("VK_FORMAT_R16G16_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Snorm = 78,

    [NativeName("VK_FORMAT_R16G16_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Uscaled = 79,

    [NativeName("VK_FORMAT_R16G16_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Sscaled = 80,

    [NativeName("VK_FORMAT_R16G16_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Uint = 81,

    [NativeName("VK_FORMAT_R16G16_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Sint = 82,

    [NativeName("VK_FORMAT_R16G16_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16Sfloat = 83,

    [NativeName("VK_FORMAT_R16G16B16_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Unorm = 84,

    [NativeName("VK_FORMAT_R16G16B16_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Snorm = 85,

    [NativeName("VK_FORMAT_R16G16B16_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Uscaled = 86,

    [NativeName("VK_FORMAT_R16G16B16_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Sscaled = 87,

    [NativeName("VK_FORMAT_R16G16B16_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Uint = 88,

    [NativeName("VK_FORMAT_R16G16B16_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Sint = 89,

    [NativeName("VK_FORMAT_R16G16B16_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16Sfloat = 90,

    [NativeName("VK_FORMAT_R16G16B16A16_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Unorm = 91,

    [NativeName("VK_FORMAT_R16G16B16A16_SNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Snorm = 92,

    [NativeName("VK_FORMAT_R16G16B16A16_USCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Uscaled = 93,

    [NativeName("VK_FORMAT_R16G16B16A16_SSCALED")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Sscaled = 94,

    [NativeName("VK_FORMAT_R16G16B16A16_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Uint = 95,

    [NativeName("VK_FORMAT_R16G16B16A16_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Sint = 96,

    [NativeName("VK_FORMAT_R16G16B16A16_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR16G16B16A16Sfloat = 97,

    [NativeName("VK_FORMAT_R32_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32Uint = 98,

    [NativeName("VK_FORMAT_R32_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32Sint = 99,

    [NativeName("VK_FORMAT_R32_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32Sfloat = 100,

    [NativeName("VK_FORMAT_R32G32_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32Uint = 101,

    [NativeName("VK_FORMAT_R32G32_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32Sint = 102,

    [NativeName("VK_FORMAT_R32G32_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32Sfloat = 103,

    [NativeName("VK_FORMAT_R32G32B32_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32Uint = 104,

    [NativeName("VK_FORMAT_R32G32B32_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32Sint = 105,

    [NativeName("VK_FORMAT_R32G32B32_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32Sfloat = 106,

    [NativeName("VK_FORMAT_R32G32B32A32_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32A32Uint = 107,

    [NativeName("VK_FORMAT_R32G32B32A32_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32A32Sint = 108,

    [NativeName("VK_FORMAT_R32G32B32A32_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR32G32B32A32Sfloat = 109,

    [NativeName("VK_FORMAT_R64_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64Uint = 110,

    [NativeName("VK_FORMAT_R64_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64Sint = 111,

    [NativeName("VK_FORMAT_R64_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64Sfloat = 112,

    [NativeName("VK_FORMAT_R64G64_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64Uint = 113,

    [NativeName("VK_FORMAT_R64G64_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64Sint = 114,

    [NativeName("VK_FORMAT_R64G64_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64Sfloat = 115,

    [NativeName("VK_FORMAT_R64G64B64_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64Uint = 116,

    [NativeName("VK_FORMAT_R64G64B64_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64Sint = 117,

    [NativeName("VK_FORMAT_R64G64B64_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64Sfloat = 118,

    [NativeName("VK_FORMAT_R64G64B64A64_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64A64Uint = 119,

    [NativeName("VK_FORMAT_R64G64B64A64_SINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64A64Sint = 120,

    [NativeName("VK_FORMAT_R64G64B64A64_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatR64G64B64A64Sfloat = 121,

    [NativeName("VK_FORMAT_B10G11R11_UFLOAT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatB10G11R11UfloatPack32 = 122,

    [NativeName("VK_FORMAT_E5B9G9R9_UFLOAT_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatE5B9G9R9UfloatPack32 = 123,

    [NativeName("VK_FORMAT_D16_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatD16Unorm = 124,

    [NativeName("VK_FORMAT_X8_D24_UNORM_PACK32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatX8D24UnormPack32 = 125,

    [NativeName("VK_FORMAT_D32_SFLOAT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatD32Sfloat = 126,

    [NativeName("VK_FORMAT_S8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatS8Uint = 127,

    [NativeName("VK_FORMAT_D16_UNORM_S8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatD16UnormS8Uint = 128,

    [NativeName("VK_FORMAT_D24_UNORM_S8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatD24UnormS8Uint = 129,

    [NativeName("VK_FORMAT_D32_SFLOAT_S8_UINT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatD32SfloatS8Uint = 130,

    [NativeName("VK_FORMAT_BC1_RGB_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc1RgbUnormBlock = 131,

    [NativeName("VK_FORMAT_BC1_RGB_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc1RgbSrgbBlock = 132,

    [NativeName("VK_FORMAT_BC1_RGBA_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc1RgbaUnormBlock = 133,

    [NativeName("VK_FORMAT_BC1_RGBA_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc1RgbaSrgbBlock = 134,

    [NativeName("VK_FORMAT_BC2_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc2UnormBlock = 135,

    [NativeName("VK_FORMAT_BC2_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc2SrgbBlock = 136,

    [NativeName("VK_FORMAT_BC3_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc3UnormBlock = 137,

    [NativeName("VK_FORMAT_BC3_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc3SrgbBlock = 138,

    [NativeName("VK_FORMAT_BC4_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc4UnormBlock = 139,

    [NativeName("VK_FORMAT_BC4_SNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc4SnormBlock = 140,

    [NativeName("VK_FORMAT_BC5_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc5UnormBlock = 141,

    [NativeName("VK_FORMAT_BC5_SNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc5SnormBlock = 142,

    [NativeName("VK_FORMAT_BC6H_UFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc6HUfloatBlock = 143,

    [NativeName("VK_FORMAT_BC6H_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc6HSfloatBlock = 144,

    [NativeName("VK_FORMAT_BC7_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc7UnormBlock = 145,

    [NativeName("VK_FORMAT_BC7_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatBc7SrgbBlock = 146,

    [NativeName("VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8UnormBlock = 147,

    [NativeName("VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8SrgbBlock = 148,

    [NativeName("VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8A1UnormBlock = 149,

    [NativeName("VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8A1SrgbBlock = 150,

    [NativeName("VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8A8UnormBlock = 151,

    [NativeName("VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEtc2R8G8B8A8SrgbBlock = 152,

    [NativeName("VK_FORMAT_EAC_R11_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEacR11UnormBlock = 153,

    [NativeName("VK_FORMAT_EAC_R11_SNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEacR11SnormBlock = 154,

    [NativeName("VK_FORMAT_EAC_R11G11_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEacR11G11UnormBlock = 155,

    [NativeName("VK_FORMAT_EAC_R11G11_SNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatEacR11G11SnormBlock = 156,

    [NativeName("VK_FORMAT_ASTC_4x4_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc4x4UnormBlock = 157,

    [NativeName("VK_FORMAT_ASTC_4x4_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc4x4SrgbBlock = 158,

    [NativeName("VK_FORMAT_ASTC_5x4_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc5x4UnormBlock = 159,

    [NativeName("VK_FORMAT_ASTC_5x4_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc5x4SrgbBlock = 160,

    [NativeName("VK_FORMAT_ASTC_5x5_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc5x5UnormBlock = 161,

    [NativeName("VK_FORMAT_ASTC_5x5_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc5x5SrgbBlock = 162,

    [NativeName("VK_FORMAT_ASTC_6x5_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc6x5UnormBlock = 163,

    [NativeName("VK_FORMAT_ASTC_6x5_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc6x5SrgbBlock = 164,

    [NativeName("VK_FORMAT_ASTC_6x6_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc6x6UnormBlock = 165,

    [NativeName("VK_FORMAT_ASTC_6x6_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc6x6SrgbBlock = 166,

    [NativeName("VK_FORMAT_ASTC_8x5_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x5UnormBlock = 167,

    [NativeName("VK_FORMAT_ASTC_8x5_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x5SrgbBlock = 168,

    [NativeName("VK_FORMAT_ASTC_8x6_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x6UnormBlock = 169,

    [NativeName("VK_FORMAT_ASTC_8x6_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x6SrgbBlock = 170,

    [NativeName("VK_FORMAT_ASTC_8x8_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x8UnormBlock = 171,

    [NativeName("VK_FORMAT_ASTC_8x8_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc8x8SrgbBlock = 172,

    [NativeName("VK_FORMAT_ASTC_10x5_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x5UnormBlock = 173,

    [NativeName("VK_FORMAT_ASTC_10x5_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x5SrgbBlock = 174,

    [NativeName("VK_FORMAT_ASTC_10x6_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x6UnormBlock = 175,

    [NativeName("VK_FORMAT_ASTC_10x6_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x6SrgbBlock = 176,

    [NativeName("VK_FORMAT_ASTC_10x8_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x8UnormBlock = 177,

    [NativeName("VK_FORMAT_ASTC_10x8_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x8SrgbBlock = 178,

    [NativeName("VK_FORMAT_ASTC_10x10_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x10UnormBlock = 179,

    [NativeName("VK_FORMAT_ASTC_10x10_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc10x10SrgbBlock = 180,

    [NativeName("VK_FORMAT_ASTC_12x10_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc12x10UnormBlock = 181,

    [NativeName("VK_FORMAT_ASTC_12x10_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc12x10SrgbBlock = 182,

    [NativeName("VK_FORMAT_ASTC_12x12_UNORM_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc12x12UnormBlock = 183,

    [NativeName("VK_FORMAT_ASTC_12x12_SRGB_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatAstc12x12SrgbBlock = 184,

    [NativeName("VK_FORMAT_G8B8G8R8_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8G8R8x422Unorm = 1000156000,

    [NativeName("VK_FORMAT_B8G8R8G8_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatB8G8R8G8x422Unorm = 1000156001,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8R8x3Plane420Unorm = 1000156002,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_420_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8R8x2Plane420Unorm = 1000156003,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8R8x3Plane422Unorm = 1000156004,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8R8x2Plane422Unorm = 1000156005,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG8B8R8x3Plane444Unorm = 1000156006,

    [NativeName("VK_FORMAT_R10X6_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR10x6UnormPack16 = 1000156007,

    [NativeName("VK_FORMAT_R10X6G10X6_UNORM_2PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR10x6G10x6Unorm2Pack16 = 1000156008,

    [NativeName("VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR10x6G10x6B10x6A10x6Unorm4Pack16 = 1000156009,

    [NativeName("VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6G10x6R10x6x422Unorm4Pack16 = 1000156010,

    [NativeName("VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatB10x6G10x6R10x6G10x6x422Unorm4Pack16 = 1000156011,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6R10x6x3Plane420Unorm3Pack16 = 1000156012,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6R10x6x2Plane420Unorm3Pack16 = 1000156013,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6R10x6x3Plane422Unorm3Pack16 = 1000156014,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6R10x6x2Plane422Unorm3Pack16 = 1000156015,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG10x6B10x6R10x6x3Plane444Unorm3Pack16 = 1000156016,

    [NativeName("VK_FORMAT_R12X4_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR12x4UnormPack16 = 1000156017,

    [NativeName("VK_FORMAT_R12X4G12X4_UNORM_2PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR12x4G12x4Unorm2Pack16 = 1000156018,

    [NativeName("VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatR12x4G12x4B12x4A12x4Unorm4Pack16 = 1000156019,

    [NativeName("VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4G12x4R12x4x422Unorm4Pack16 = 1000156020,

    [NativeName("VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatB12x4G12x4R12x4G12x4x422Unorm4Pack16 = 1000156021,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4R12x4x3Plane420Unorm3Pack16 = 1000156022,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4R12x4x2Plane420Unorm3Pack16 = 1000156023,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4R12x4x3Plane422Unorm3Pack16 = 1000156024,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4R12x4x2Plane422Unorm3Pack16 = 1000156025,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG12x4B12x4R12x4x3Plane444Unorm3Pack16 = 1000156026,

    [NativeName("VK_FORMAT_G16B16G16R16_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16G16R16x422Unorm = 1000156027,

    [NativeName("VK_FORMAT_B16G16R16G16_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatB16G16R16G16x422Unorm = 1000156028,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16R16x3Plane420Unorm = 1000156029,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_420_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16R16x2Plane420Unorm = 1000156030,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16R16x3Plane422Unorm = 1000156031,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_422_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16R16x2Plane422Unorm = 1000156032,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkFormatG16B16R16x3Plane444Unorm = 1000156033,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_444_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatG8B8R8x2Plane444Unorm = 1000330000,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatG10x6B10x6R10x6x2Plane444Unorm3Pack16 = 1000330001,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatG12x4B12x4R12x4x2Plane444Unorm3Pack16 = 1000330002,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_444_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatG16B16R16x2Plane444Unorm = 1000330003,

    [NativeName("VK_FORMAT_A4R4G4B4_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatA4R4G4B4UnormPack16 = 1000340000,

    [NativeName("VK_FORMAT_A4B4G4R4_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatA4B4G4R4UnormPack16 = 1000340001,

    [NativeName("VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc4x4SfloatBlock = 1000066000,

    [NativeName("VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc5x4SfloatBlock = 1000066001,

    [NativeName("VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc5x5SfloatBlock = 1000066002,

    [NativeName("VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc6x5SfloatBlock = 1000066003,

    [NativeName("VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc6x6SfloatBlock = 1000066004,

    [NativeName("VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc8x5SfloatBlock = 1000066005,

    [NativeName("VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc8x6SfloatBlock = 1000066006,

    [NativeName("VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc8x8SfloatBlock = 1000066007,

    [NativeName("VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc10x5SfloatBlock = 1000066008,

    [NativeName("VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc10x6SfloatBlock = 1000066009,

    [NativeName("VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc10x8SfloatBlock = 1000066010,

    [NativeName("VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc10x10SfloatBlock = 1000066011,

    [NativeName("VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc12x10SfloatBlock = 1000066012,

    [NativeName("VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkFormatAstc12x12SfloatBlock = 1000066013,

    [NativeName("VK_FORMAT_A1B5G5R5_UNORM_PACK16")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkFormatA1B5G5R5UnormPack16 = 1000470000,

    [NativeName("VK_FORMAT_A8_UNORM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    VkFormatA8Unorm = 1000470001,

    [NativeName("VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc1x2BppUnormBlockIMG = 1000054000,

    [NativeName("VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc1x4BppUnormBlockIMG = 1000054001,

    [NativeName("VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc2x2BppUnormBlockIMG = 1000054002,

    [NativeName("VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc2x4BppUnormBlockIMG = 1000054003,

    [NativeName("VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc1x2BppSrgbBlockIMG = 1000054004,

    [NativeName("VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc1x4BppSrgbBlockIMG = 1000054005,

    [NativeName("VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc2x2BppSrgbBlockIMG = 1000054006,

    [NativeName("VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG")]
    [NameAffix("Suffix", "KhronosVendor", "IMG")]
    [SupportedApiProfile("vulkan", ["VK_IMG_format_pvrtc"])]
    VkFormatPvrtc2x4BppSrgbBlockIMG = 1000054007,

    [NativeName("VK_FORMAT_R8_BOOL_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    VkFormatR8BoolARM = 1000460000,

    [NativeName("VK_FORMAT_R16G16_SFIXED5_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkFormatR16G16Sfixed5NV = 1000464000,

    [NativeName("VK_FORMAT_R10X6_UINT_PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6UintPack16ARM = 1000609000,

    [NativeName("VK_FORMAT_R10X6G10X6_UINT_2PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6G10x6Uint2Pack16ARM = 1000609001,

    [NativeName("VK_FORMAT_R10X6G10X6B10X6A10X6_UINT_4PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6G10x6B10x6A10x6Uint4Pack16ARM = 1000609002,

    [NativeName("VK_FORMAT_R12X4_UINT_PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4UintPack16ARM = 1000609003,

    [NativeName("VK_FORMAT_R12X4G12X4_UINT_2PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4G12x4Uint2Pack16ARM = 1000609004,

    [NativeName("VK_FORMAT_R12X4G12X4B12X4A12X4_UINT_4PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4G12x4B12x4A12x4Uint4Pack16ARM = 1000609005,

    [NativeName("VK_FORMAT_R14X2_UINT_PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2UintPack16ARM = 1000609006,

    [NativeName("VK_FORMAT_R14X2G14X2_UINT_2PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2G14x2Uint2Pack16ARM = 1000609007,

    [NativeName("VK_FORMAT_R14X2G14X2B14X2A14X2_UINT_4PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2G14x2B14x2A14x2Uint4Pack16ARM = 1000609008,

    [NativeName("VK_FORMAT_R14X2_UNORM_PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2UnormPack16ARM = 1000609009,

    [NativeName("VK_FORMAT_R14X2G14X2_UNORM_2PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2G14x2Unorm2Pack16ARM = 1000609010,

    [NativeName("VK_FORMAT_R14X2G14X2B14X2A14X2_UNORM_4PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatR14x2G14x2B14x2A14x2Unorm4Pack16ARM = 1000609011,

    [NativeName("VK_FORMAT_G14X2_B14X2R14X2_2PLANE_420_UNORM_3PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatG14x2B14x2R14x2x2Plane420Unorm3Pack16ARM = 1000609012,

    [NativeName("VK_FORMAT_G14X2_B14X2R14X2_2PLANE_422_UNORM_3PACK16_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    VkFormatG14x2B14x2R14x2x2Plane422Unorm3Pack16ARM = 1000609013,

    [NativeName("VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc4x4SfloatBlockEXT = VkFormatAstc4x4SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc5x4SfloatBlockEXT = VkFormatAstc5x4SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc5x5SfloatBlockEXT = VkFormatAstc5x5SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc6x5SfloatBlockEXT = VkFormatAstc6x5SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc6x6SfloatBlockEXT = VkFormatAstc6x6SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc8x5SfloatBlockEXT = VkFormatAstc8x5SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc8x6SfloatBlockEXT = VkFormatAstc8x6SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc8x8SfloatBlockEXT = VkFormatAstc8x8SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc10x5SfloatBlockEXT = VkFormatAstc10x5SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc10x6SfloatBlockEXT = VkFormatAstc10x6SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc10x8SfloatBlockEXT = VkFormatAstc10x8SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc10x10SfloatBlockEXT = VkFormatAstc10x10SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc12x10SfloatBlockEXT = VkFormatAstc12x10SfloatBlock,

    [NativeName("VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_texture_compression_astc_hdr"],
        ImpliesSets = [
            "VK_EXT_texture_compression_astc_hdr+VK_KHR_get_physical_device_properties2",
            "VK_EXT_texture_compression_astc_hdr+VK_VERSION_1_1",
        ]
    )]
    VkFormatAstc12x12SfloatBlockEXT = VkFormatAstc12x12SfloatBlock,

    [NativeName("VK_FORMAT_G8B8G8R8_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8G8R8x422UnormKHR = VkFormatG8B8G8R8x422Unorm,

    [NativeName("VK_FORMAT_B8G8R8G8_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatB8G8R8G8x422UnormKHR = VkFormatB8G8R8G8x422Unorm,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x3Plane420UnormKHR = VkFormatG8B8R8x3Plane420Unorm,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x2Plane420UnormKHR = VkFormatG8B8R8x2Plane420Unorm,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x3Plane422UnormKHR = VkFormatG8B8R8x3Plane422Unorm,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x2Plane422UnormKHR = VkFormatG8B8R8x2Plane422Unorm,

    [NativeName("VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x3Plane444UnormKHR = VkFormatG8B8R8x3Plane444Unorm,

    [NativeName("VK_FORMAT_R10X6_UNORM_PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6UnormPack16KHR = VkFormatR10x6UnormPack16,

    [NativeName("VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6G10x6Unorm2Pack16KHR = VkFormatR10x6G10x6Unorm2Pack16,

    [NativeName("VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR10x6G10x6B10x6A10x6Unorm4Pack16KHR = VkFormatR10x6G10x6B10x6A10x6Unorm4Pack16,

    [NativeName("VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6G10x6R10x6x422Unorm4Pack16KHR = VkFormatG10x6B10x6G10x6R10x6x422Unorm4Pack16,

    [NativeName("VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatB10x6G10x6R10x6G10x6x422Unorm4Pack16KHR = VkFormatB10x6G10x6R10x6G10x6x422Unorm4Pack16,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x3Plane420Unorm3Pack16KHR =
        VkFormatG10x6B10x6R10x6x3Plane420Unorm3Pack16,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x2Plane420Unorm3Pack16KHR =
        VkFormatG10x6B10x6R10x6x2Plane420Unorm3Pack16,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x3Plane422Unorm3Pack16KHR =
        VkFormatG10x6B10x6R10x6x3Plane422Unorm3Pack16,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x2Plane422Unorm3Pack16KHR =
        VkFormatG10x6B10x6R10x6x2Plane422Unorm3Pack16,

    [NativeName("VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x3Plane444Unorm3Pack16KHR =
        VkFormatG10x6B10x6R10x6x3Plane444Unorm3Pack16,

    [NativeName("VK_FORMAT_R12X4_UNORM_PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4UnormPack16KHR = VkFormatR12x4UnormPack16,

    [NativeName("VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4G12x4Unorm2Pack16KHR = VkFormatR12x4G12x4Unorm2Pack16,

    [NativeName("VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatR12x4G12x4B12x4A12x4Unorm4Pack16KHR = VkFormatR12x4G12x4B12x4A12x4Unorm4Pack16,

    [NativeName("VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4G12x4R12x4x422Unorm4Pack16KHR = VkFormatG12x4B12x4G12x4R12x4x422Unorm4Pack16,

    [NativeName("VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatB12x4G12x4R12x4G12x4x422Unorm4Pack16KHR = VkFormatB12x4G12x4R12x4G12x4x422Unorm4Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x3Plane420Unorm3Pack16KHR =
        VkFormatG12x4B12x4R12x4x3Plane420Unorm3Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x2Plane420Unorm3Pack16KHR =
        VkFormatG12x4B12x4R12x4x2Plane420Unorm3Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x3Plane422Unorm3Pack16KHR =
        VkFormatG12x4B12x4R12x4x3Plane422Unorm3Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x2Plane422Unorm3Pack16KHR =
        VkFormatG12x4B12x4R12x4x2Plane422Unorm3Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x3Plane444Unorm3Pack16KHR =
        VkFormatG12x4B12x4R12x4x3Plane444Unorm3Pack16,

    [NativeName("VK_FORMAT_G16B16G16R16_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16G16R16x422UnormKHR = VkFormatG16B16G16R16x422Unorm,

    [NativeName("VK_FORMAT_B16G16R16G16_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatB16G16R16G16x422UnormKHR = VkFormatB16G16R16G16x422Unorm,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x3Plane420UnormKHR = VkFormatG16B16R16x3Plane420Unorm,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x2Plane420UnormKHR = VkFormatG16B16R16x2Plane420Unorm,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x3Plane422UnormKHR = VkFormatG16B16R16x3Plane422Unorm,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x2Plane422UnormKHR = VkFormatG16B16R16x2Plane422Unorm,

    [NativeName("VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x3Plane444UnormKHR = VkFormatG16B16R16x3Plane444Unorm,

    [NativeName("VK_FORMAT_G8_B8R8_2PLANE_444_UNORM_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatG8B8R8x2Plane444UnormEXT = VkFormatG8B8R8x2Plane444Unorm,

    [NativeName("VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatG10x6B10x6R10x6x2Plane444Unorm3Pack16EXT =
        VkFormatG10x6B10x6R10x6x2Plane444Unorm3Pack16,

    [NativeName("VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatG12x4B12x4R12x4x2Plane444Unorm3Pack16EXT =
        VkFormatG12x4B12x4R12x4x2Plane444Unorm3Pack16,

    [NativeName("VK_FORMAT_G16_B16R16_2PLANE_444_UNORM_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_2plane_444_formats"],
        ImpliesSets = [
            "VK_EXT_ycbcr_2plane_444_formats+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_2plane_444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatG16B16R16x2Plane444UnormEXT = VkFormatG16B16R16x2Plane444Unorm,

    [NativeName("VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatA4R4G4B4UnormPack16EXT = VkFormatA4R4G4B4UnormPack16,

    [NativeName("VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_4444_formats"],
        ImpliesSets = [
            "VK_EXT_4444_formats+VK_KHR_get_physical_device_properties2",
            "VK_EXT_4444_formats+VK_VERSION_1_1",
        ]
    )]
    VkFormatA4B4G4R4UnormPack16EXT = VkFormatA4B4G4R4UnormPack16,

    [NativeName("VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkFormatA1B5G5R5UnormPack16KHR = VkFormatA1B5G5R5UnormPack16,

    [NativeName("VK_FORMAT_A8_UNORM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance5"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_dynamic_rendering", "VK_VERSION_1_3"]
    )]
    VkFormatA8UnormKHR = VkFormatA8Unorm,

    [NativeName("VK_FORMAT_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_0",
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_0",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_0",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.0"
    )]
    VkFormatMaxEnum = 0x7FFFFFFF,
}
