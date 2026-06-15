// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughLayerCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughLayerCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public StructureType Type = StructureType.TypePassthroughLayerCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public void* Next;

    [NativeName("passthrough")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughHandleFB Passthrough;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughFlagsFB Flags;

    [NativeName("purpose")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughLayerPurposeFB Purpose;

    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughLayerCreateInfoFB() { }
}
