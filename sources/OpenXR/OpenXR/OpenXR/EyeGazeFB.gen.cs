// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeGazeFB")]
[SupportedApiProfile("openxr")]
public partial struct EyeGazeFB
{
    [NativeName("isValid")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public MaybeBool<uint> IsValid;

    [NativeName("gazePose")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public Posef GazePose;

    [NativeName("gazeConfidence")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public float GazeConfidence;
}
