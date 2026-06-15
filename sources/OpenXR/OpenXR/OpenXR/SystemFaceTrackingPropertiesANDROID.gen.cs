// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemFaceTrackingPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemFaceTrackingPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public StructureType Type = StructureType.TypeSystemFaceTrackingPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public void* Next;

    [NativeName("supportsFaceTracking")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public MaybeBool<uint> SupportsFaceTracking;

    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public SystemFaceTrackingPropertiesANDROID() { }
}
