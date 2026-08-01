// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationDepthRangeEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ViewConfigurationDepthRangeEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public StructureType Type = StructureType.ViewConfigurationDepthRangeEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public void* Next;

    [NativeName("recommendedNearZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public float RecommendedNearZ;

    [NativeName("minNearZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public float MinNearZ;

    [NativeName("recommendedFarZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public float RecommendedFarZ;

    [NativeName("maxFarZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public float MaxFarZ;

    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public ViewConfigurationDepthRangeEXT() { }
}
