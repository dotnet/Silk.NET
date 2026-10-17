// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointsMotionRangeEXT")]
public enum HandJointsMotionRangeEXT : uint
{
    [NativeName("XR_HAND_JOINTS_MOTION_RANGE_UNOBSTRUCTED_EXT")]
    Unobstructed = 1,

    [NativeName("XR_HAND_JOINTS_MOTION_RANGE_CONFORMING_TO_CONTROLLER_EXT")]
    ConformingToController = 2,
}
