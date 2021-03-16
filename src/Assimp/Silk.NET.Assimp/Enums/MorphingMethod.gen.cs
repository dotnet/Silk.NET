// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMorphingMethod")]
    public enum MorphingMethod : int
    {
        [NativeName("Name", "aiMorphingMethod_VERTEX_BLEND")]
        MorphingMethodVertexBlend = 0x1,
        [NativeName("Name", "aiMorphingMethod_MORPH_NORMALIZED")]
        MorphingMethodMorphNormalized = 0x2,
        [NativeName("Name", "aiMorphingMethod_MORPH_RELATIVE")]
        MorphingMethodMorphRelative = 0x3,
    }
}
