// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceTrackerCreateInfo2FB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FaceTrackerCreateInfo2FB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public StructureType Type = StructureType.FaceTrackerCreateInfo2FB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public void* Next;

    [NativeName("faceExpressionSet")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public FaceExpressionSet2FB FaceExpressionSet;

    [NativeName("requestedDataSourceCount")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public uint RequestedDataSourceCount;

    [NativeName("requestedDataSources")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public FaceTrackingDataSource2FB* RequestedDataSources;

    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public FaceTrackerCreateInfo2FB() { }
}
