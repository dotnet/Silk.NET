// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerSpaceCreateInfoVARJO")]
[SupportedApiProfile("openxr")]
public unsafe partial struct MarkerSpaceCreateInfoVARJO
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public StructureType Type = StructureType.MarkerSpaceCreateInfoVARJO;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public void* Next;

    [NativeName("markerId")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public ulong MarkerId;

    [NativeName("poseInMarkerSpace")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public Posef PoseInMarkerSpace;

    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public MarkerSpaceCreateInfoVARJO() { }
}
