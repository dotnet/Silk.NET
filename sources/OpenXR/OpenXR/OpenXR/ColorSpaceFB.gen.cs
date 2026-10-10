// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrColorSpaceFB")]
[SupportedApiProfile("openxr")]
public enum ColorSpaceFB : uint
{
    [NativeName("XR_COLOR_SPACE_UNMANAGED_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    Unmanaged = 0,

    [NativeName("XR_COLOR_SPACE_REC2020_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    Rec2020 = 1,

    [NativeName("XR_COLOR_SPACE_REC709_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    Rec709 = 2,

    [NativeName("XR_COLOR_SPACE_RIFT_CV1_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    RiftCv1 = 3,

    [NativeName("XR_COLOR_SPACE_RIFT_S_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    RiftS = 4,

    [NativeName("XR_COLOR_SPACE_QUEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    Quest = 5,

    [NativeName("XR_COLOR_SPACE_P3_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    P3 = 6,

    [NativeName("XR_COLOR_SPACE_ADOBE_RGB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    AdobeRgb = 7,
}
