// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialMarkerAprilTagDictEXT")]
public enum SpatialMarkerAprilTagDictEXT : uint
{
    [NativeName("XR_SPATIAL_MARKER_APRIL_TAG_DICT_16H5_EXT")]
    Dict16H5 = 1,

    [NativeName("XR_SPATIAL_MARKER_APRIL_TAG_DICT_25H9_EXT")]
    Dict25H9 = 2,

    [NativeName("XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H10_EXT")]
    Dict36H10 = 3,

    [NativeName("XR_SPATIAL_MARKER_APRIL_TAG_DICT_36H11_EXT")]
    Dict36H11 = 4,
}
