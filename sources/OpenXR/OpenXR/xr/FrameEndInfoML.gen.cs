// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameEndInfoML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FrameEndInfoML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public StructureType Type = StructureType.FrameEndInfoML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public void* Next;

    [NativeName("focusDistance")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public float FocusDistance;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public FrameEndInfoFlagsML Flags;

    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public FrameEndInfoML() { }
}
