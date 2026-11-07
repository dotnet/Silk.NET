// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPlaneDetectionPropertiesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemPlaneDetectionPropertiesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public StructureType Type = StructureType.SystemPlaneDetectionPropertiesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public void* Next;

    [NativeName("supportedFeatures")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectionCapabilityFlagsEXT SupportedFeatures;

    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public SystemPlaneDetectionPropertiesEXT() { }
}
