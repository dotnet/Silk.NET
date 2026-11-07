// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorArucoInfoML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct MarkerDetectorArucoInfoML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public StructureType Type = StructureType.MarkerDetectorArucoInfoML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public void* Next;

    [NativeName("arucoDict")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerArucoDictML ArucoDict;

    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorArucoInfoML() { }
}
