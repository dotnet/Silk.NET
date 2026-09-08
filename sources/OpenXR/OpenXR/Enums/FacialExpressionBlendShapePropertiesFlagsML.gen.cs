// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialExpressionBlendShapePropertiesFlagsML")]
[Flags]
public enum FacialExpressionBlendShapePropertiesFlagsML : ulong
{
    None = 0x0,

    [NativeName("XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_VALID_BIT_ML")]
    ValidBit = 0x1,

    [NativeName("XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_TRACKED_BIT_ML")]
    TrackedBit = 0x2,
}
