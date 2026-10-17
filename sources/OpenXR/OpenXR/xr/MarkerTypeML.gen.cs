// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerTypeML")]
public enum MarkerTypeML : uint
{
    [NativeName("XR_MARKER_TYPE_ARUCO_ML")]
    Aruco = 0,

    [NativeName("XR_MARKER_TYPE_APRIL_TAG_ML")]
    AprilTag = 1,

    [NativeName("XR_MARKER_TYPE_QR_ML")]
    Qr = 2,

    [NativeName("XR_MARKER_TYPE_EAN_13_ML")]
    Ean13 = 3,

    [NativeName("XR_MARKER_TYPE_UPC_A_ML")]
    UpcA = 4,

    [NativeName("XR_MARKER_TYPE_CODE_128_ML")]
    Code128 = 5,
}
