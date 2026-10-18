// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVector3f")]
[SupportedApiProfile("openxr")]
public partial struct Vector3F
{
    [NativeName("x")]
    [SupportedApiProfile("openxr")]
    public float X;

    [NativeName("y")]
    [SupportedApiProfile("openxr")]
    public float Y;

    [NativeName("z")]
    [SupportedApiProfile("openxr")]
    public float Z;
}
