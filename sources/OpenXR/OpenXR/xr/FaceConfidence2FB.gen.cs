// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceConfidence2FB")]
public enum FaceConfidence2FB : uint
{
    [NativeName("XR_FACE_CONFIDENCE2_LOWER_FACE_FB")]
    LowerFace = 0,

    [NativeName("XR_FACE_CONFIDENCE2_UPPER_FACE_FB")]
    UpperFace = 1,

    [NativeName("XR_FACE_CONFIDENCE2_COUNT_FB")]
    Count = 2,
}
