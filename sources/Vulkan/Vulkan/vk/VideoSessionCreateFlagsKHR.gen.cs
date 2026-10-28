// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoSessionCreateFlagsKHR")]
[Flags]
public enum VideoSessionCreateFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR")]
    ProtectedContentBit = 0x1,

    [NativeName("VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR")]
    AllowEncodeParameterOptimizationsBit = 0x2,

    [NativeName("VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR")]
    InlineQueriesBit = 0x4,

    [NativeName("VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
    AllowEncodeQuantizationDeltaMapBit = 0x8,

    [NativeName("VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_EMPHASIS_MAP_BIT_KHR")]
    AllowEncodeEmphasisMapBit = 0x10,

    [NativeName("VK_VIDEO_SESSION_CREATE_INLINE_SESSION_PARAMETERS_BIT_KHR")]
    InlineSessionParametersBit = 0x20,
}
