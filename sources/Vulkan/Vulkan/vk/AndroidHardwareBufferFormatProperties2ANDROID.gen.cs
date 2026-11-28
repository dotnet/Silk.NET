// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAndroidHardwareBufferFormatProperties2ANDROID")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct AndroidHardwareBufferFormatProperties2ANDROID
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.AndroidHardwareBufferFormatProperties2ANDROID;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("format")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public Format Format;

    [NativeName("externalFormat")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public ulong ExternalFormat;

    [NativeName("formatFeatures")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public FormatFeatureFlags2 FormatFeatures;

    [NativeName("samplerYcbcrConversionComponents")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public ComponentMapping SamplerYcbcrConversionComponents;

    [NativeName("suggestedYcbcrModel")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public SamplerYcbcrModelConversion SuggestedYcbcrModel;

    [NativeName("suggestedYcbcrRange")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public SamplerYcbcrRange SuggestedYcbcrRange;

    [NativeName("suggestedXChromaOffset")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public ChromaLocation SuggestedXChromaOffset;

    [NativeName("suggestedYChromaOffset")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public ChromaLocation SuggestedYChromaOffset;

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_KHR_format_feature_flags2",
            "VK_ANDROID_external_memory_android_hardware_buffer+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public AndroidHardwareBufferFormatProperties2ANDROID() { }
}
