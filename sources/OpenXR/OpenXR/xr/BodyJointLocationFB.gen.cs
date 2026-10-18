// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointLocationFB")]
[SupportedApiProfile("openxr")]
public partial struct BodyJointLocationFB
{
    [NativeName("locationFlags")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public SpaceLocationFlags LocationFlags;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public Posef Pose;
}
