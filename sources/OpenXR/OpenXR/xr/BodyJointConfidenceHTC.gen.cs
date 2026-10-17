// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointConfidenceHTC")]
public enum BodyJointConfidenceHTC : uint
{
    [NativeName("XR_BODY_JOINT_CONFIDENCE_NONE_HTC")]
    None = 0,

    [NativeName("XR_BODY_JOINT_CONFIDENCE_LOW_HTC")]
    Low = 1,

    [NativeName("XR_BODY_JOINT_CONFIDENCE_HIGH_HTC")]
    High = 2,
}
