// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceVelocityFlags")]
[Flags]
public enum SpaceVelocityFlags : ulong
{
    None = 0x0,

    [NativeName("XR_SPACE_VELOCITY_LINEAR_VALID_BIT")]
    LinearValidBit = 0x1,

    [NativeName("XR_SPACE_VELOCITY_ANGULAR_VALID_BIT")]
    AngularValidBit = 0x2,
}
