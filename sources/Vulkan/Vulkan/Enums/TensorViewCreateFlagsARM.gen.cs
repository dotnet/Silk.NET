// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum TensorViewCreateFlagsARM : ulong
{
    None = 0,
    DescriptorBufferCaptureReplayBitARM = unchecked((ulong)0x00000001UL),
}
