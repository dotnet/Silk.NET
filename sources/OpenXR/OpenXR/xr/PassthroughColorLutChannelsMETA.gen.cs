// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughColorLutChannelsMETA")]
[SupportedApiProfile("openxr")]
public enum PassthroughColorLutChannelsMETA : uint
{
    [NativeName("XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGB_META")]
    [SupportedApiProfile("openxr")]
    Rgb = 1,

    [NativeName("XR_PASSTHROUGH_COLOR_LUT_CHANNELS_RGBA_META")]
    [SupportedApiProfile("openxr")]
    Rgba = 2,
}
