// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "CombinerParameterNV")]
    public enum CombinerParameterNV : int
    {
        [Obsolete("Deprecated in favour of \"InputNV\"")]
        [NativeName("Name", "GL_COMBINER_INPUT_NV")]
        CombinerInputNV = 0x8542,
        [Obsolete("Deprecated in favour of \"MappingNV\"")]
        [NativeName("Name", "GL_COMBINER_MAPPING_NV")]
        CombinerMappingNV = 0x8543,
        [Obsolete("Deprecated in favour of \"ComponentUsageNV\"")]
        [NativeName("Name", "GL_COMBINER_COMPONENT_USAGE_NV")]
        CombinerComponentUsageNV = 0x8544,
        [NativeName("Name", "GL_COMBINER_INPUT_NV")]
        InputNV = 0x8542,
        [NativeName("Name", "GL_COMBINER_MAPPING_NV")]
        MappingNV = 0x8543,
        [NativeName("Name", "GL_COMBINER_COMPONENT_USAGE_NV")]
        ComponentUsageNV = 0x8544,
    }
}
