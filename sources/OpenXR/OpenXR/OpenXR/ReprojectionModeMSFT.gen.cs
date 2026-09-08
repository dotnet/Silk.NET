// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrReprojectionModeMSFT")]
[SupportedApiProfile("openxr")]
public enum ReprojectionModeMSFT : uint
{
    [NativeName("XR_REPROJECTION_MODE_DEPTH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    Depth = 1,

    [NativeName("XR_REPROJECTION_MODE_PLANAR_FROM_DEPTH_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    PlanarFromDepth = 2,

    [NativeName("XR_REPROJECTION_MODE_PLANAR_MANUAL_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    PlanarManual = 3,

    [NativeName("XR_REPROJECTION_MODE_ORIENTATION_ONLY_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    OrientationOnly = 4,
}
