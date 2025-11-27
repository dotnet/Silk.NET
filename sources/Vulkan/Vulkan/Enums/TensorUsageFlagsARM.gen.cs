// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum TensorUsageFlagsARM : ulong
{
    None = 0x0,
    ShaderBitARM = 0x2,
    TransferSrcBitARM = 0x4,
    TransferDstBitARM = 0x8,
    ImageAliasingBitARM = 0x10,
    DataGraphBitARM = 0x20,
}
