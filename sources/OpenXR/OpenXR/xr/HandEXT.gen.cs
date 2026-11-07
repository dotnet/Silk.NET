// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandEXT")]
[SupportedApiProfile("openxr")]
public enum HandEXT : uint
{
    [NativeName("XR_HAND_LEFT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    Left = 1,

    [NativeName("XR_HAND_RIGHT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    Right = 2,
}
