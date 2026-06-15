// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewStateFlags")]
[Flags]
public enum ViewStateFlags : ulong
{
    None = 0x0,

    [NativeName("XR_VIEW_STATE_ORIENTATION_VALID_BIT")]
    OrientationValidBit = 0x1,

    [NativeName("XR_VIEW_STATE_POSITION_VALID_BIT")]
    PositionValidBit = 0x2,

    [NativeName("XR_VIEW_STATE_ORIENTATION_TRACKED_BIT")]
    OrientationTrackedBit = 0x4,

    [NativeName("XR_VIEW_STATE_POSITION_TRACKED_BIT")]
    PositionTrackedBit = 0x8,
}
