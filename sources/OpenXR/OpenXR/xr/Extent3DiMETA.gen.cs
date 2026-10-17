// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExtent3DiMETA")]
public partial struct Extent3DiMETA
{
    [NativeName("width")]
    public int Width;

    [NativeName("height")]
    public int Height;

    [NativeName("depth")]
    public int Depth;
}
