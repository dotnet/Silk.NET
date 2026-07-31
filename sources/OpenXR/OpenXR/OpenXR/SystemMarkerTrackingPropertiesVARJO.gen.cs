// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemMarkerTrackingPropertiesVARJO")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemMarkerTrackingPropertiesVARJO
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public StructureType Type = StructureType.SystemMarkerTrackingPropertiesVARJO;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public void* Next;

    [NativeName("supportsMarkerTracking")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public MaybeBool<uint> SupportsMarkerTracking;

    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public SystemMarkerTrackingPropertiesVARJO() { }
}
