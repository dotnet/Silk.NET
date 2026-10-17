// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneOrientationBD")]
public enum PlaneOrientationBD : uint
{
    [NativeName("XR_PLANE_ORIENTATION_HORIZONTAL_UPWARD_BD")]
    HorizontalUpward = 0,

    [NativeName("XR_PLANE_ORIENTATION_HORIZONTAL_DOWNWARD_BD")]
    HorizontalDownward = 1,

    [NativeName("XR_PLANE_ORIENTATION_VERTICAL_BD")]
    Vertical = 2,

    [NativeName("XR_PLANE_ORIENTATION_ARBITRARY_BD")]
    Arbitrary = 3,
}
