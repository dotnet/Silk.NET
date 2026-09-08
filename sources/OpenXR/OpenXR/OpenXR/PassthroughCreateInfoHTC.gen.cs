// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughCreateInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughCreateInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public StructureType Type = StructureType.PassthroughCreateInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public void* Next;

    [NativeName("form")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public PassthroughFormHTC Form;

    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public PassthroughCreateInfoHTC() { }
}
