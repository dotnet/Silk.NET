// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorCustomProfileInfoML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct MarkerDetectorCustomProfileInfoML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public StructureType Type = StructureType.MarkerDetectorCustomProfileInfoML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public void* Next;

    [NativeName("fpsHint")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorFpsML FpsHint;

    [NativeName("resolutionHint")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorResolutionML ResolutionHint;

    [NativeName("cameraHint")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorCameraML CameraHint;

    [NativeName("cornerRefineMethod")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorCornerRefineMethodML CornerRefineMethod;

    [NativeName("useEdgeRefinement")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MaybeBool<uint> UseEdgeRefinement;

    [NativeName("fullAnalysisIntervalHint")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorFullAnalysisIntervalML FullAnalysisIntervalHint;

    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public MarkerDetectorCustomProfileInfoML() { }
}
