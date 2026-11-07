// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialBufferTypeEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialBufferTypeEXT : uint
{
    [NativeName("XR_SPATIAL_BUFFER_TYPE_UNKNOWN_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Unknown = 0,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_STRING_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    String = 1,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT8_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Uint8 = 2,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT16_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Uint16 = 3,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT32_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Uint32 = 4,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_FLOAT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Float = 5,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_VECTOR2F_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Vector2F = 6,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_VECTOR3F_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Vector3F = 7,
}
