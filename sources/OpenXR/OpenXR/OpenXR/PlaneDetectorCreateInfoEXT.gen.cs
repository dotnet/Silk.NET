// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorCreateInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PlaneDetectorCreateInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public StructureType Type = StructureType.PlaneDetectorCreateInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorFlagsEXT Flags;

    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorCreateInfoEXT() { }
}
