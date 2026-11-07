// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughFormHTC")]
[SupportedApiProfile("openxr")]
public enum PassthroughFormHTC : uint
{
    [NativeName("XR_PASSTHROUGH_FORM_PLANAR_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    Planar = 0,

    [NativeName("XR_PASSTHROUGH_FORM_PROJECTED_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    Projected = 1,
}
