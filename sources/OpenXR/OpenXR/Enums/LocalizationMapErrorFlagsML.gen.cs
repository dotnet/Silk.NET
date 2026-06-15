// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLocalizationMapErrorFlagsML")]
[Flags]
public enum LocalizationMapErrorFlagsML : ulong
{
    None = 0x0,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_UNKNOWN_BIT_ML")]
    UnknownBit = 0x1,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_OUT_OF_MAPPED_AREA_BIT_ML")]
    OutOfMappedAreaBit = 0x2,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_LOW_FEATURE_COUNT_BIT_ML")]
    LowFeatureCountBit = 0x4,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_EXCESSIVE_MOTION_BIT_ML")]
    ExcessiveMotionBit = 0x8,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_LOW_LIGHT_BIT_ML")]
    LowLightBit = 0x10,

    [NativeName("XR_LOCALIZATION_MAP_ERROR_HEADPOSE_BIT_ML")]
    HeadposeBit = 0x20,
}
