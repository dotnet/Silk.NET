// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceValueDataINTEL")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct PerformanceValueDataINTEL
{
    [NativeName("value32")]
    [FieldOffset(0)]
    public uint Value32;

    [NativeName("value64")]
    [FieldOffset(0)]
    public ulong Value64;

    [NativeName("valueFloat")]
    [FieldOffset(0)]
    public float ValueFloat;

    [NativeName("valueBool")]
    [FieldOffset(0)]
    public MaybeBool<uint> ValueBool;

    [NativeName("valueString")]
    [FieldOffset(0)]
    public sbyte* ValueString;
}
