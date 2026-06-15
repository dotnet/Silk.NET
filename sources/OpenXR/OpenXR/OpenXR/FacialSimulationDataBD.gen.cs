// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialSimulationDataBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FacialSimulationDataBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public StructureType Type = StructureType.TypeFacialSimulationDataBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public void* Next;

    [NativeName("faceExpressionWeightCount")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public uint FaceExpressionWeightCount;

    [NativeName("faceExpressionWeights")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public float* FaceExpressionWeights;

    [NativeName("isUpperFaceDataValid")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public MaybeBool<uint> IsUpperFaceDataValid;

    [NativeName("isLowerFaceDataValid")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public MaybeBool<uint> IsLowerFaceDataValid;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public FacialSimulationDataBD() { }
}
