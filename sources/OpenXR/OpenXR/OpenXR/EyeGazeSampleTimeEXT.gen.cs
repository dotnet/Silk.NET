// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeGazeSampleTimeEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EyeGazeSampleTimeEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public StructureType Type = StructureType.TypeEyeGazeSampleTimeEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public void* Next;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public EyeGazeSampleTimeEXT() { }
}
