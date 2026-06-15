// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataViveTrackerConnectedHTCX")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataViveTrackerConnectedHTCX
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public StructureType Type = StructureType.TypeEventDataViveTrackerConnectedHTCX;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public void* Next;

    [NativeName("paths")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public ViveTrackerPathsHTCX* Paths;

    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public EventDataViveTrackerConnectedHTCX() { }
}
