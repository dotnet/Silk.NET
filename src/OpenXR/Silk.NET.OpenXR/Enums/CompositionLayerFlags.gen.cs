// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrCompositionLayerFlags")]
    public enum CompositionLayerFlags : int
    {
        [NativeName("Name", "XR_COMPOSITION_LAYER_CORRECT_CHROMATIC_ABERRATION_BIT")]
        CompositionLayerCorrectChromaticAberrationBit = 1,
        [NativeName("Name", "XR_COMPOSITION_LAYER_BLEND_TEXTURE_SOURCE_ALPHA_BIT")]
        CompositionLayerBlendTextureSourceAlphaBit = 2,
        [NativeName("Name", "XR_COMPOSITION_LAYER_UNPREMULTIPLIED_ALPHA_BIT")]
        CompositionLayerUnpremultipliedAlphaBit = 4,
    }
}
