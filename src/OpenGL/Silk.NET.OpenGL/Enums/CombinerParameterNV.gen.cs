// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "CombinerParameterNV")]
    public enum CombinerParameterNV : int
    {
        [NativeName("Name", "GL_COMBINER_INPUT_NV")]
        CombinerInputNV = 0x8542,
        [NativeName("Name", "GL_COMBINER_MAPPING_NV")]
        CombinerMappingNV = 0x8543,
        [NativeName("Name", "GL_COMBINER_COMPONENT_USAGE_NV")]
        CombinerComponentUsageNV = 0x8544,
    }
}
