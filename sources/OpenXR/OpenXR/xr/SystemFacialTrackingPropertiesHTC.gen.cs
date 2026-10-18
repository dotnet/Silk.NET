// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemFacialTrackingPropertiesHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemFacialTrackingPropertiesHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public StructureType Type = StructureType.SystemFacialTrackingPropertiesHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public void* Next;

    [NativeName("supportEyeFacialTracking")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public MaybeBool<uint> SupportEyeFacialTracking;

    [NativeName("supportLipFacialTracking")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public MaybeBool<uint> SupportLipFacialTracking;

    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public SystemFacialTrackingPropertiesHTC() { }
}
