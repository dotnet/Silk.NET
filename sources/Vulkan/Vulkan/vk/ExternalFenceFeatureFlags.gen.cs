// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalFenceFeatureFlags")]
[Flags]
public enum ExternalFenceFeatureFlags : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT")]
    ExportableBit = 0x1,

    [NativeName("VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT")]
    ImportableBit = 0x2,

    [NativeName("VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR")]
    ExportableBitKHR = ExportableBit,

    [NativeName("VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR")]
    ImportableBitKHR = ImportableBit,
}
