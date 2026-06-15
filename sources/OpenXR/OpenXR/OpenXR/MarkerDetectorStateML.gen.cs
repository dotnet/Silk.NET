// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorStateML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct MarkerDetectorStateML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public StructureType Type = StructureType.TypeMarkerDetectorStateML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public void* Next;

    [NativeName("state")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorStatusML State;

    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorStateML() { }
}
