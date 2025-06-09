// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ExternalMemoryHandleTypeFlagsNV : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32BitNV = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32KmtBitNV = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageBitNV = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageKmtBitNV = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    FlagBitsMaxEnumNV = 0x7FFFFFFF,
}
