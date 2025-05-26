// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum ExternalMemoryFeatureFlagsNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    DedicatedOnlyBitNV = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    ExportableBitNV = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    ImportableBitNV = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    FlagBitsMaxEnumNV = 0x7FFFFFFF,
}
