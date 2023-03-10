// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMorphingMethod")]
    public enum MorphingMethod : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "aiMorphingMethod_UNKNOWN")]
        MorphingMethodUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"VertexBlend\"")]
        [NativeName("Name", "aiMorphingMethod_VERTEX_BLEND")]
        MorphingMethodVertexBlend = 0x1,
        [Obsolete("Deprecated in favour of \"MorphNormalized\"")]
        [NativeName("Name", "aiMorphingMethod_MORPH_NORMALIZED")]
        MorphingMethodMorphNormalized = 0x2,
        [Obsolete("Deprecated in favour of \"MorphRelative\"")]
        [NativeName("Name", "aiMorphingMethod_MORPH_RELATIVE")]
        MorphingMethodMorphRelative = 0x3,
        [NativeName("Name", "aiMorphingMethod_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "aiMorphingMethod_VERTEX_BLEND")]
        VertexBlend = 0x1,
        [NativeName("Name", "aiMorphingMethod_MORPH_NORMALIZED")]
        MorphNormalized = 0x2,
        [NativeName("Name", "aiMorphingMethod_MORPH_RELATIVE")]
        MorphRelative = 0x3,
    }
}
