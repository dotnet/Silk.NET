// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemFaceTrackingVisemesPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemFaceTrackingVisemesPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SystemFaceTrackingVisemesPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("supportsVisemes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> SupportsVisemes;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public SystemFaceTrackingVisemesPropertiesMETA() { }
}
