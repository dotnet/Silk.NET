// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrOffset2Df")]
[SupportedApiProfile("openxr")]
public partial struct Offset2Df
{
    [NativeName("x")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public float X;

    [NativeName("y")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public float Y;
}
