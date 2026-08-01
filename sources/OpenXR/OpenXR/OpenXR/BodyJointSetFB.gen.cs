// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointSetFB")]
[SupportedApiProfile("openxr")]
public enum BodyJointSetFB : uint
{
    [NativeName("XR_BODY_JOINT_SET_DEFAULT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Default = 0,

    [NativeName("XR_BODY_JOINT_SET_FULL_BODY_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    FullBodyMETA = 1000274000,
}
