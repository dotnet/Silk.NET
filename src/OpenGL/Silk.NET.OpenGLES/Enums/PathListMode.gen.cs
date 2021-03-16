// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathListMode")]
    public enum PathListMode : int
    {
        [NativeName("Name", "GL_ACCUM_ADJACENT_PAIRS_NV")]
        AccumAdjacentPairsNV = 0x90AD,
        [NativeName("Name", "GL_ADJACENT_PAIRS_NV")]
        AdjacentPairsNV = 0x90AE,
        [NativeName("Name", "GL_FIRST_TO_REST_NV")]
        FirstToRestNV = 0x90AF,
    }
}
