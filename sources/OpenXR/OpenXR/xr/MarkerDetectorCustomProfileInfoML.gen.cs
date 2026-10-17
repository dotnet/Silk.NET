// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorCustomProfileInfoML")]
public unsafe partial struct MarkerDetectorCustomProfileInfoML
{
    [NativeName("type")]
    public StructureType Type = StructureType.MarkerDetectorCustomProfileInfoML;

    [NativeName("next")]
    public void* Next;

    [NativeName("fpsHint")]
    public MarkerDetectorFpsML FpsHint;

    [NativeName("resolutionHint")]
    public MarkerDetectorResolutionML ResolutionHint;

    [NativeName("cameraHint")]
    public MarkerDetectorCameraML CameraHint;

    [NativeName("cornerRefineMethod")]
    public MarkerDetectorCornerRefineMethodML CornerRefineMethod;

    [NativeName("useEdgeRefinement")]
    public MaybeBool<uint> UseEdgeRefinement;

    [NativeName("fullAnalysisIntervalHint")]
    public MarkerDetectorFullAnalysisIntervalML FullAnalysisIntervalHint;

    public MarkerDetectorCustomProfileInfoML() { }
}
