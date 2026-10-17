// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneTypeANDROID")]
public enum PlaneTypeANDROID : uint
{
    [NativeName("XR_PLANE_TYPE_HORIZONTAL_DOWNWARD_FACING_ANDROID")]
    HorizontalDownwardFacing = 0,

    [NativeName("XR_PLANE_TYPE_HORIZONTAL_UPWARD_FACING_ANDROID")]
    HorizontalUpwardFacing = 1,

    [NativeName("XR_PLANE_TYPE_VERTICAL_ANDROID")]
    Vertical = 2,

    [NativeName("XR_PLANE_TYPE_ARBITRARY_ANDROID")]
    Arbitrary = 3,
}
