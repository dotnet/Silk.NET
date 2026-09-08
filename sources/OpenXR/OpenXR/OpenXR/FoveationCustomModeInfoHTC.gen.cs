// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationCustomModeInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FoveationCustomModeInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public StructureType Type = StructureType.FoveationCustomModeInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public void* Next;

    [NativeName("configCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public uint ConfigCount;

    [NativeName("configs")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public FoveationConfigurationHTC* Configs;

    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public FoveationCustomModeInfoHTC() { }
}
