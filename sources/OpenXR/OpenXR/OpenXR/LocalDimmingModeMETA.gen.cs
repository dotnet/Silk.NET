// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLocalDimmingModeMETA")]
[SupportedApiProfile("openxr")]
public enum LocalDimmingModeMETA : uint
{
    [NativeName("XR_LOCAL_DIMMING_MODE_OFF_META")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    Off = 0,

    [NativeName("XR_LOCAL_DIMMING_MODE_ON_META")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    On = 1,
}
