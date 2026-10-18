// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughPreferencesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughPreferencesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public StructureType Type = StructureType.PassthroughPreferencesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public PassthroughPreferenceFlagsMETA Flags;

    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public PassthroughPreferencesMETA() { }
}
