// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialExpressionsHTC")]
public unsafe partial struct FacialExpressionsHTC
{
    [NativeName("type")]
    public StructureType Type = StructureType.FacialExpressionsHTC;

    [NativeName("next")]
    public void* Next;

    [NativeName("isActive")]
    public MaybeBool<uint> IsActive;

    [NativeName("sampleTime")]
    public long SampleTime;

    [NativeName("expressionCount")]
    public uint ExpressionCount;

    [NativeName("expressionWeightings")]
    public float* ExpressionWeightings;

    public FacialExpressionsHTC() { }
}
