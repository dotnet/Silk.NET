// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialExpressionsHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FacialExpressionsHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public StructureType Type = StructureType.TypeFacialExpressionsHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public void* Next;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public MaybeBool<uint> IsActive;

    [NativeName("sampleTime")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public long SampleTime;

    [NativeName("expressionCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public uint ExpressionCount;

    [NativeName("expressionWeightings")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public float* ExpressionWeightings;

    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public FacialExpressionsHTC() { }
}
