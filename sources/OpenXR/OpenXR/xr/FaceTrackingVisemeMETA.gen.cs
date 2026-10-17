// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceTrackingVisemeMETA")]
public enum FaceTrackingVisemeMETA : uint
{
    [NativeName("XR_FACE_TRACKING_VISEME_SIL_META")]
    Sil = 0,

    [NativeName("XR_FACE_TRACKING_VISEME_PP_META")]
    Pp = 1,

    [NativeName("XR_FACE_TRACKING_VISEME_FF_META")]
    Ff = 2,

    [NativeName("XR_FACE_TRACKING_VISEME_TH_META")]
    Th = 3,

    [NativeName("XR_FACE_TRACKING_VISEME_DD_META")]
    Dd = 4,

    [NativeName("XR_FACE_TRACKING_VISEME_KK_META")]
    Kk = 5,

    [NativeName("XR_FACE_TRACKING_VISEME_CH_META")]
    Ch = 6,

    [NativeName("XR_FACE_TRACKING_VISEME_SS_META")]
    Ss = 7,

    [NativeName("XR_FACE_TRACKING_VISEME_NN_META")]
    Nn = 8,

    [NativeName("XR_FACE_TRACKING_VISEME_RR_META")]
    Rr = 9,

    [NativeName("XR_FACE_TRACKING_VISEME_AA_META")]
    Aa = 10,

    [NativeName("XR_FACE_TRACKING_VISEME_E_META")]
    E = 11,

    [NativeName("XR_FACE_TRACKING_VISEME_IH_META")]
    Ih = 12,

    [NativeName("XR_FACE_TRACKING_VISEME_OH_META")]
    Oh = 13,

    [NativeName("XR_FACE_TRACKING_VISEME_OU_META")]
    Ou = 14,
}
