// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum MemoryDecompressionMethodFlagsEXT : ulong
{
    None = 0x0,
    MemoryDecompressionMethodGdeflate1X0BitEXT = 0x1,
    MemoryDecompressionMethodGdeflate1X0BitNV = 0x1,
}
