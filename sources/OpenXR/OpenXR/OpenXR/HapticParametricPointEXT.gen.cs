// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticParametricPointEXT")]
[SupportedApiProfile("openxr")]
public partial struct HapticParametricPointEXT
{
    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public long Time;

    [NativeName("value")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public float Value;
}
