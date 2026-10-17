// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialSimulationDataBD")]
public unsafe partial struct FacialSimulationDataBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.FacialSimulationDataBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("faceExpressionWeightCount")]
    public uint FaceExpressionWeightCount;

    [NativeName("faceExpressionWeights")]
    public float* FaceExpressionWeights;

    [NativeName("isUpperFaceDataValid")]
    public MaybeBool<uint> IsUpperFaceDataValid;

    [NativeName("isLowerFaceDataValid")]
    public MaybeBool<uint> IsLowerFaceDataValid;

    [NativeName("time")]
    public long Time;

    public FacialSimulationDataBD() { }
}
