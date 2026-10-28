// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkProvokingVertexModeEXT")]
public enum ProvokingVertexModeEXT : uint
{
    [NativeName("VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT")]
    FirstVertex = 0,

    [NativeName("VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT")]
    LastVertex = 1,
}
