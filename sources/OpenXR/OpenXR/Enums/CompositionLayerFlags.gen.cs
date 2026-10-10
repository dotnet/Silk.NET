// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerFlags")]
[Flags]
public enum CompositionLayerFlags : ulong
{
    None = 0x0,

    [NativeName("XR_COMPOSITION_LAYER_CORRECT_CHROMATIC_ABERRATION_BIT")]
    CorrectChromaticAberrationBit = 0x1,

    [NativeName("XR_COMPOSITION_LAYER_BLEND_TEXTURE_SOURCE_ALPHA_BIT")]
    BlendTextureSourceAlphaBit = 0x2,

    [NativeName("XR_COMPOSITION_LAYER_UNPREMULTIPLIED_ALPHA_BIT")]
    UnpremultipliedAlphaBit = 0x4,

    [NativeName("XR_COMPOSITION_LAYER_INVERTED_ALPHA_BIT_EXT")]
    InvertedAlphaBitEXT = 0x8,
}
