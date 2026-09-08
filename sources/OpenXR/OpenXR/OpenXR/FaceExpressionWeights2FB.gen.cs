// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionWeights2FB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FaceExpressionWeights2FB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public StructureType Type = StructureType.FaceExpressionWeights2FB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public void* Next;

    [NativeName("weightCount")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public uint WeightCount;

    [NativeName("weights")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public float* Weights;

    [NativeName("confidenceCount")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public uint ConfidenceCount;

    [NativeName("confidences")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public float* Confidences;

    [NativeName("isValid")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public MaybeBool<uint> IsValid;

    [NativeName("isEyeFollowingBlendshapesValid")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public MaybeBool<uint> IsEyeFollowingBlendshapesValid;

    [NativeName("dataSource")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public FaceTrackingDataSource2FB DataSource;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public FaceExpressionWeights2FB() { }
}
