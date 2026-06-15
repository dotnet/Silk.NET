// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceStateANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FaceStateANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public StructureType Type = StructureType.TypeFaceStateANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public void* Next;

    [NativeName("parametersCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public uint ParametersCapacityInput;

    [NativeName("parametersCountOutput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public uint ParametersCountOutput;

    [NativeName("parameters")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public float* Parameters;

    [NativeName("faceTrackingState")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public FaceTrackingStateANDROID FaceTrackingState;

    [NativeName("sampleTime")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public long SampleTime;

    [NativeName("isValid")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public MaybeBool<uint> IsValid;

    [NativeName("regionConfidencesCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public uint RegionConfidencesCapacityInput;

    [NativeName("regionConfidencesCountOutput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public uint RegionConfidencesCountOutput;

    [NativeName("regionConfidences")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public float* RegionConfidences;

    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public FaceStateANDROID() { }
}
