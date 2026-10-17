// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrForceFeedbackCurlLocationMNDX")]
public enum ForceFeedbackCurlLocationMNDX : uint
{
    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_THUMB_CURL_MNDX")]
    ThumbCurl = 0,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_INDEX_CURL_MNDX")]
    IndexCurl = 1,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_MIDDLE_CURL_MNDX")]
    MiddleCurl = 2,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_RING_CURL_MNDX")]
    RingCurl = 3,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_LITTLE_CURL_MNDX")]
    LittleCurl = 4,
}
