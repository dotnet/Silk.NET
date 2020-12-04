// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathListMode")]
    public enum PathListMode
    {
        [NativeName("Name", "GL_ACCUM_ADJACENT_PAIRS_NV")]
        AccumAdjacentPairsNV = 0x90AD,
        [NativeName("Name", "GL_ADJACENT_PAIRS_NV")]
        AdjacentPairsNV = 0x90AE,
        [NativeName("Name", "GL_FIRST_TO_REST_NV")]
        FirstToRestNV = 0x90AF,
    }
}
