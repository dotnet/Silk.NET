// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndexType")]
public enum IndexType : uint
{
    [NativeName("VK_INDEX_TYPE_UINT16")]
    Uint16 = 0,

    [NativeName("VK_INDEX_TYPE_UINT32")]
    Uint32 = 1,

    [NativeName("VK_INDEX_TYPE_UINT8")]
    Uint8 = 1000265000,

    [NativeName("VK_INDEX_TYPE_NONE_KHR")]
    NoneKHR = 1000165000,

    [NativeName("VK_INDEX_TYPE_NONE_NV")]
    NoneNV = NoneKHR,

    [NativeName("VK_INDEX_TYPE_UINT8_EXT")]
    Uint8EXT = Uint8,

    [NativeName("VK_INDEX_TYPE_UINT8_KHR")]
    Uint8KHR = Uint8,
}
