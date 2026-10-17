// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPerformanceMetricsCounterMETA")]
public unsafe partial struct PerformanceMetricsCounterMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.PerformanceMetricsCounterMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("counterFlags")]
    public PerformanceMetricsCounterFlagsMETA CounterFlags;

    [NativeName("counterUnit")]
    public PerformanceMetricsCounterUnitMETA CounterUnit;

    [NativeName("uintValue")]
    public uint UintValue;

    [NativeName("floatValue")]
    public float FloatValue;

    public PerformanceMetricsCounterMETA() { }
}
