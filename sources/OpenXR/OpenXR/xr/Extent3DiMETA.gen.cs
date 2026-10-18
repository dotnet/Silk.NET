// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExtent3DiMETA")]
[SupportedApiProfile("openxr")]
public partial struct Extent3DiMETA
{
    [NativeName("width")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public int Width;

    [NativeName("height")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public int Height;

    [NativeName("depth")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public int Depth;
}
