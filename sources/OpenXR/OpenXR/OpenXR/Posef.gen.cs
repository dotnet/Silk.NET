// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPosef")]
[SupportedApiProfile("openxr")]
public partial struct Posef
{
    [NativeName("orientation")]
    [SupportedApiProfile("openxr")]
    public Quaternionf Orientation;

    [NativeName("position")]
    [SupportedApiProfile("openxr")]
    public Vector3F Position;
}
