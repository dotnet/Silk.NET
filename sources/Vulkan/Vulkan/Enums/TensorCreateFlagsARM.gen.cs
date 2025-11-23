// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum TensorCreateFlagsARM : ulong
{
    None = 0,
    MutableFormatBitARM = unchecked((ulong)0x00000001UL),
    ProtectedBitARM = unchecked((ulong)0x00000002UL),
    DescriptorBufferCaptureReplayBitARM = unchecked((ulong)0x00000004UL),
}
