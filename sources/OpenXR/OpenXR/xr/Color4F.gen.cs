// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrColor4f")]
public partial struct Color4F
{
    [NativeName("r")]
    public float R;

    [NativeName("g")]
    public float G;

    [NativeName("b")]
    public float B;

    [NativeName("a")]
    public float A;
}
