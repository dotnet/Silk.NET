// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerAprilTagDictML")]
[SupportedApiProfile("openxr")]
public enum MarkerAprilTagDictML : uint
{
    [NativeName("XR_MARKER_APRIL_TAG_DICT_16H5_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict16H5 = 0,

    [NativeName("XR_MARKER_APRIL_TAG_DICT_25H9_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict25H9 = 1,

    [NativeName("XR_MARKER_APRIL_TAG_DICT_36H10_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict36H10 = 2,

    [NativeName("XR_MARKER_APRIL_TAG_DICT_36H11_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict36H11 = 3,
}
