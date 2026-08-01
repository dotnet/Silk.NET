// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceTrackingVisemeMETA")]
[SupportedApiProfile("openxr")]
public enum FaceTrackingVisemeMETA : uint
{
    [NativeName("XR_FACE_TRACKING_VISEME_SIL_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Sil = 0,

    [NativeName("XR_FACE_TRACKING_VISEME_PP_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Pp = 1,

    [NativeName("XR_FACE_TRACKING_VISEME_FF_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Ff = 2,

    [NativeName("XR_FACE_TRACKING_VISEME_TH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Th = 3,

    [NativeName("XR_FACE_TRACKING_VISEME_DD_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Dd = 4,

    [NativeName("XR_FACE_TRACKING_VISEME_KK_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Kk = 5,

    [NativeName("XR_FACE_TRACKING_VISEME_CH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Ch = 6,

    [NativeName("XR_FACE_TRACKING_VISEME_SS_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Ss = 7,

    [NativeName("XR_FACE_TRACKING_VISEME_NN_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Nn = 8,

    [NativeName("XR_FACE_TRACKING_VISEME_RR_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Rr = 9,

    [NativeName("XR_FACE_TRACKING_VISEME_AA_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Aa = 10,

    [NativeName("XR_FACE_TRACKING_VISEME_E_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    E = 11,

    [NativeName("XR_FACE_TRACKING_VISEME_IH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Ih = 12,

    [NativeName("XR_FACE_TRACKING_VISEME_OH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Oh = 13,

    [NativeName("XR_FACE_TRACKING_VISEME_OU_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    Ou = 14,
}
