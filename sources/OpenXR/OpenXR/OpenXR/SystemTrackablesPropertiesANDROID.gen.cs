// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemTrackablesPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemTrackablesPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public StructureType Type = StructureType.TypeSystemTrackablesPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public void* Next;

    [NativeName("supportsAnchor")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public MaybeBool<uint> SupportsAnchor;

    [NativeName("maxAnchors")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public uint MaxAnchors;

    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public SystemTrackablesPropertiesANDROID() { }
}
