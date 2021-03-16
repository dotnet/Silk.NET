// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "CombinerStageNV")]
    public enum CombinerStageNV : int
    {
        [NativeName("Name", "GL_COMBINER0_NV")]
        Combiner0NV = 0x8550,
        [NativeName("Name", "GL_COMBINER1_NV")]
        Combiner1NV = 0x8551,
        [NativeName("Name", "GL_COMBINER2_NV")]
        Combiner2NV = 0x8552,
        [NativeName("Name", "GL_COMBINER3_NV")]
        Combiner3NV = 0x8553,
        [NativeName("Name", "GL_COMBINER4_NV")]
        Combiner4NV = 0x8554,
        [NativeName("Name", "GL_COMBINER5_NV")]
        Combiner5NV = 0x8555,
        [NativeName("Name", "GL_COMBINER6_NV")]
        Combiner6NV = 0x8556,
        [NativeName("Name", "GL_COMBINER7_NV")]
        Combiner7NV = 0x8557,
    }
}
