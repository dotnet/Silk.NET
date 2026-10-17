// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialObjectSemanticLabelANDROID")]
public enum SpatialObjectSemanticLabelANDROID : uint
{
    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_UNCATEGORIZED_ANDROID")]
    Uncategorized = 0,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_KEYBOARD_ANDROID")]
    Keyboard = 1,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_MOUSE_ANDROID")]
    Mouse = 2,

    [NativeName("XR_SPATIAL_OBJECT_SEMANTIC_LABEL_LAPTOP_BASE_ANDROID")]
    LaptopBase = 3,
}
