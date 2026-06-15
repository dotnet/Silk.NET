// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemFaceTrackingProperties2FB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemFaceTrackingProperties2FB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public StructureType Type = StructureType.TypeSystemFaceTrackingProperties2FB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public void* Next;

    [NativeName("supportsVisualFaceTracking")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public MaybeBool<uint> SupportsVisualFaceTracking;

    [NativeName("supportsAudioFaceTracking")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public MaybeBool<uint> SupportsAudioFaceTracking;

    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public SystemFaceTrackingProperties2FB() { }
}
