// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalMemoryFeatureFlagBitsNV")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ExternalMemoryFeatureFlagsNV : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    DedicatedOnlyBitNV = 0x1,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    ExportableBitNV = 0x2,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    ImportableBitNV = 0x4,
}
