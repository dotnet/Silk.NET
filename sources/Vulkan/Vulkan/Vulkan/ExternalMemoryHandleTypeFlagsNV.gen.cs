// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ExternalMemoryHandleTypeFlagsNV : uint
{
    None = 0x0,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32BitNV = 0x1,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32KmtBitNV = 0x2,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageBitNV = 0x4,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageKmtBitNV = 0x8,
}
