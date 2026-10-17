// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceStateANDROID")]
public unsafe partial struct FaceStateANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.FaceStateANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("parametersCapacityInput")]
    public uint ParametersCapacityInput;

    [NativeName("parametersCountOutput")]
    public uint ParametersCountOutput;

    [NativeName("parameters")]
    public float* Parameters;

    [NativeName("faceTrackingState")]
    public FaceTrackingStateANDROID FaceTrackingState;

    [NativeName("sampleTime")]
    public long SampleTime;

    [NativeName("isValid")]
    public MaybeBool<uint> IsValid;

    [NativeName("regionConfidencesCapacityInput")]
    public uint RegionConfidencesCapacityInput;

    [NativeName("regionConfidencesCountOutput")]
    public uint RegionConfidencesCountOutput;

    [NativeName("regionConfidences")]
    public float* RegionConfidences;

    public FaceStateANDROID() { }
}
