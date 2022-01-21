// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
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
