// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialTrackerCreateInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FacialTrackerCreateInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public StructureType Type = StructureType.FacialTrackerCreateInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public void* Next;

    [NativeName("facialTrackingType")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public FacialTrackingTypeHTC FacialTrackingType;

    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public FacialTrackerCreateInfoHTC() { }
}
