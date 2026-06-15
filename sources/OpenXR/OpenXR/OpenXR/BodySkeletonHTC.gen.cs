// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodySkeletonHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodySkeletonHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public StructureType Type = StructureType.TypeBodySkeletonHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public void* Next;

    [NativeName("jointCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public uint JointCount;

    [NativeName("joints")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodySkeletonJointHTC* Joints;

    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodySkeletonHTC() { }
}
