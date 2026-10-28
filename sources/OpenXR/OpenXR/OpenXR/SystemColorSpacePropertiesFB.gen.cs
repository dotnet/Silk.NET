// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemColorSpacePropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemColorSpacePropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public StructureType Type = StructureType.SystemColorSpacePropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public void* Next;

    [NativeName("colorSpace")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public ColorSpaceFB ColorSpace;

    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public SystemColorSpacePropertiesFB() { }
}
