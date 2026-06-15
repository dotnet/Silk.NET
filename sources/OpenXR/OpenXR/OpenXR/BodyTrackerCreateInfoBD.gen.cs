// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyTrackerCreateInfoBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyTrackerCreateInfoBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public StructureType Type = StructureType.TypeBodyTrackerCreateInfoBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public void* Next;

    [NativeName("jointSet")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public BodyJointSetBD JointSet;

    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public BodyTrackerCreateInfoBD() { }
}
