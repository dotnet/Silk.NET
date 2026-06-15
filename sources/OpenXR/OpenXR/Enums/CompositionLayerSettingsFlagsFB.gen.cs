// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerSettingsFlagsFB")]
[Flags]
public enum CompositionLayerSettingsFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SUPER_SAMPLING_BIT_FB")]
    NormalSuperSamplingBit = 0x1,

    [NativeName("XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SUPER_SAMPLING_BIT_FB")]
    QualitySuperSamplingBit = 0x2,

    [NativeName("XR_COMPOSITION_LAYER_SETTINGS_NORMAL_SHARPENING_BIT_FB")]
    NormalSharpeningBit = 0x4,

    [NativeName("XR_COMPOSITION_LAYER_SETTINGS_QUALITY_SHARPENING_BIT_FB")]
    QualitySharpeningBit = 0x8,

    [NativeName("XR_COMPOSITION_LAYER_SETTINGS_AUTO_LAYER_FILTER_BIT_META")]
    AutoLayerFilterBitMETA = 0x20,
}
