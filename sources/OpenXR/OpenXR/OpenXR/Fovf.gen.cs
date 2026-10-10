// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFovf")]
[SupportedApiProfile("openxr")]
public partial struct Fovf
{
    [NativeName("angleLeft")]
    [SupportedApiProfile("openxr")]
    public float AngleLeft;

    [NativeName("angleRight")]
    [SupportedApiProfile("openxr")]
    public float AngleRight;

    [NativeName("angleUp")]
    [SupportedApiProfile("openxr")]
    public float AngleUp;

    [NativeName("angleDown")]
    [SupportedApiProfile("openxr")]
    public float AngleDown;
}
