// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyMicromapModeEXT")]
public enum CopyMicromapModeEXT : uint
{
    [NativeName("VK_COPY_MICROMAP_MODE_CLONE_EXT")]
    Clone = 0,

    [NativeName("VK_COPY_MICROMAP_MODE_SERIALIZE_EXT")]
    Serialize = 1,

    [NativeName("VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT")]
    Deserialize = 2,

    [NativeName("VK_COPY_MICROMAP_MODE_COMPACT_EXT")]
    Compact = 3,
}
