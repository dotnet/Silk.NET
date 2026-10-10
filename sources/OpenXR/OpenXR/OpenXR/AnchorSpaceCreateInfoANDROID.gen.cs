// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAnchorSpaceCreateInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct AnchorSpaceCreateInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public StructureType Type = StructureType.AnchorSpaceCreateInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public SpaceHandle Space;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public long Time;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public Posef Pose;

    [NativeName("trackable")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public ulong Trackable;

    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public AnchorSpaceCreateInfoANDROID() { }
}
