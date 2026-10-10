// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceTrackerCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FaceTrackerCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public StructureType Type = StructureType.FaceTrackerCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public void* Next;

    [NativeName("faceExpressionSet")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public FaceExpressionSetFB FaceExpressionSet;

    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public FaceTrackerCreateInfoFB() { }
}
