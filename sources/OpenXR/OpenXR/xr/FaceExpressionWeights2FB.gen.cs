// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionWeights2FB")]
public unsafe partial struct FaceExpressionWeights2FB
{
    [NativeName("type")]
    public StructureType Type = StructureType.FaceExpressionWeights2FB;

    [NativeName("next")]
    public void* Next;

    [NativeName("weightCount")]
    public uint WeightCount;

    [NativeName("weights")]
    public float* Weights;

    [NativeName("confidenceCount")]
    public uint ConfidenceCount;

    [NativeName("confidences")]
    public float* Confidences;

    [NativeName("isValid")]
    public MaybeBool<uint> IsValid;

    [NativeName("isEyeFollowingBlendshapesValid")]
    public MaybeBool<uint> IsEyeFollowingBlendshapesValid;

    [NativeName("dataSource")]
    public FaceTrackingDataSource2FB DataSource;

    [NativeName("time")]
    public long Time;

    public FaceExpressionWeights2FB() { }
}
