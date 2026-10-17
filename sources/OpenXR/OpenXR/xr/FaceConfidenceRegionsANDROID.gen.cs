// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceConfidenceRegionsANDROID")]
public enum FaceConfidenceRegionsANDROID : uint
{
    [NativeName("XR_FACE_CONFIDENCE_REGIONS_LOWER_ANDROID")]
    Lower = 0,

    [NativeName("XR_FACE_CONFIDENCE_REGIONS_LEFT_UPPER_ANDROID")]
    LeftUpper = 1,

    [NativeName("XR_FACE_CONFIDENCE_REGIONS_RIGHT_UPPER_ANDROID")]
    RightUpper = 2,
}
