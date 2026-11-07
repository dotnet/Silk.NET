// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceCounterResultKHR")]
[StructLayout(LayoutKind.Explicit)]
public partial struct PerformanceCounterResultKHR
{
    [NativeName("int32")]
    [FieldOffset(0)]
    public int Int32;

    [NativeName("int64")]
    [FieldOffset(0)]
    public long Int64;

    [NativeName("uint32")]
    [FieldOffset(0)]
    public uint Uint32;

    [NativeName("uint64")]
    [FieldOffset(0)]
    public ulong Uint64;

    [NativeName("float32")]
    [FieldOffset(0)]
    public float Float32;

    [NativeName("float64")]
    [FieldOffset(0)]
    public double Float64;
}
