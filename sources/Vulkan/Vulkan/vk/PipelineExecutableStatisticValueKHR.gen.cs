// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineExecutableStatisticValueKHR")]
[StructLayout(LayoutKind.Explicit)]
public partial struct PipelineExecutableStatisticValueKHR
{
    [NativeName("b32")]
    [FieldOffset(0)]
    public MaybeBool<uint> B32;

    [NativeName("i64")]
    [FieldOffset(0)]
    public long I64;

    [NativeName("u64")]
    [FieldOffset(0)]
    public ulong U64;

    [NativeName("f64")]
    [FieldOffset(0)]
    public double F64;
}
