// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialObjectSemanticLabelANDROID")]
[SupportedApiProfile("openxr")]
public enum SpatialObjectSemanticLabelANDROID : uint
{
    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_UNCATEGORIZED_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Uncategorized = 0,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_KEYBOARD_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Keyboard = 1,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_MOUSE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Mouse = 2,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_LAPTOP_BASE_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    LaptopBase = 3,
}
