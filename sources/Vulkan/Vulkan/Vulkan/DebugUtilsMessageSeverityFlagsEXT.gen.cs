// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum DebugUtilsMessageSeverityFlagsEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VerboseBitEXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    InfoBitEXT = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    WarningBitEXT = 0x00000100,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    ErrorBitEXT = 0x00001000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    FlagBitsMaxEnumEXT = 0x7FFFFFFF,
}
