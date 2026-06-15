// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceConfidenceFB")]
[SupportedApiProfile("openxr")]
public enum FaceConfidenceFB : uint
{
    [NativeName("XR_FACE_CONFIDENCE_LOWER_FACE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LowerFace = 0,

    [NativeName("XR_FACE_CONFIDENCE_UPPER_FACE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    UpperFace = 1,

    [NativeName("XR_FACE_CONFIDENCE_COUNT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    Count = 2,
}
