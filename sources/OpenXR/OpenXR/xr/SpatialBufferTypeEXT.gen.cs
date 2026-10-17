// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialBufferTypeEXT")]
public enum SpatialBufferTypeEXT : uint
{
    [NativeName("XR_SPATIAL_BUFFER_TYPE_UNKNOWN_EXT")]
    Unknown = 0,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_STRING_EXT")]
    String = 1,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT8_EXT")]
    Uint8 = 2,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT16_EXT")]
    Uint16 = 3,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_UINT32_EXT")]
    Uint32 = 4,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_FLOAT_EXT")]
    Float = 5,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_VECTOR2F_EXT")]
    Vector2F = 6,

    [NativeName("XR_SPATIAL_BUFFER_TYPE_VECTOR3F_EXT")]
    Vector3F = 7,
}
