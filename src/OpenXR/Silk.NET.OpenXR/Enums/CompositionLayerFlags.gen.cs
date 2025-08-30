// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrCompositionLayerFlags")]
    public enum CompositionLayerFlags : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CorrectChromaticAberrationBit\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_CORRECT_CHROMATIC_ABERRATION_BIT")]
        CompositionLayerCorrectChromaticAberrationBit = 1,
        [Obsolete("Deprecated in favour of \"BlendTextureSourceAlphaBit\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_BLEND_TEXTURE_SOURCE_ALPHA_BIT")]
        CompositionLayerBlendTextureSourceAlphaBit = 2,
        [Obsolete("Deprecated in favour of \"UnpremultipliedAlphaBit\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_UNPREMULTIPLIED_ALPHA_BIT")]
        CompositionLayerUnpremultipliedAlphaBit = 4,
        [Obsolete("Deprecated in favour of \"InvertedAlphaBitExt\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_INVERTED_ALPHA_BIT_EXT")]
        CompositionLayerInvertedAlphaBitExt = 8,
        [NativeName("Name", "XR_COMPOSITION_LAYER_CORRECT_CHROMATIC_ABERRATION_BIT")]
        CorrectChromaticAberrationBit = 1,
        [NativeName("Name", "XR_COMPOSITION_LAYER_BLEND_TEXTURE_SOURCE_ALPHA_BIT")]
        BlendTextureSourceAlphaBit = 2,
        [NativeName("Name", "XR_COMPOSITION_LAYER_UNPREMULTIPLIED_ALPHA_BIT")]
        UnpremultipliedAlphaBit = 4,
        [NativeName("Name", "XR_COMPOSITION_LAYER_INVERTED_ALPHA_BIT_EXT")]
        InvertedAlphaBitExt = 8,
    }
}
