// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkExternalMemoryFeatureFlagBitsNV")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkExternalMemoryFeatureFlagsNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryFeatureDedicatedOnlyBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryFeatureExportableBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryFeatureImportableBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryFeatureFlagBitsMaxEnum = 0x7FFFFFFF,
}
