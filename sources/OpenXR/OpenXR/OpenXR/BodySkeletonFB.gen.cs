// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodySkeletonFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodySkeletonFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public StructureType Type = StructureType.BodySkeletonFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public void* Next;

    [NativeName("jointCount")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public uint JointCount;

    [NativeName("joints")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public BodySkeletonJointFB* Joints;

    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public BodySkeletonFB() { }
}
