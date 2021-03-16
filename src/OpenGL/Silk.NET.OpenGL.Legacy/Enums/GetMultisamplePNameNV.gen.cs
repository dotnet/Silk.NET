// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetMultisamplePNameNV")]
    public enum GetMultisamplePNameNV : int
    {
        [NativeName("Name", "GL_SAMPLE_POSITION")]
        SamplePosition = 0x8E50,
        [NativeName("Name", "GL_SAMPLE_LOCATION_ARB")]
        SampleLocationArb = 0x8E50,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
        ProgrammableSampleLocationArb = 0x9341,
    }
}
