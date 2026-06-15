// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataMarkerTrackingUpdateVARJO")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataMarkerTrackingUpdateVARJO
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public StructureType Type = StructureType.TypeEventDataMarkerTrackingUpdateVARJO;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public void* Next;

    [NativeName("markerId")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public ulong MarkerId;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public MaybeBool<uint> IsActive;

    [NativeName("isPredicted")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public MaybeBool<uint> IsPredicted;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public EventDataMarkerTrackingUpdateVARJO() { }
}
