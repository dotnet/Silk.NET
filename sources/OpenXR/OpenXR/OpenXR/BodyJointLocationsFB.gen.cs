// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointLocationsFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyJointLocationsFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public StructureType Type = StructureType.TypeBodyJointLocationsFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public void* Next;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public MaybeBool<uint> IsActive;

    [NativeName("confidence")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public float Confidence;

    [NativeName("jointCount")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public uint JointCount;

    [NativeName("jointLocations")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public BodyJointLocationFB* JointLocations;

    [NativeName("skeletonChangedCount")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public uint SkeletonChangedCount;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public BodyJointLocationsFB() { }
}
