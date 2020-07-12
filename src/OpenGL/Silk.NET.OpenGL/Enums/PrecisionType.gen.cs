// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PrecisionType")]
    public enum PrecisionType
    {
        [NativeName("Name", "GL_LOW_FLOAT")]
        LowFloat = 0x8DF0,
        [NativeName("Name", "GL_MEDIUM_FLOAT")]
        MediumFloat = 0x8DF1,
        [NativeName("Name", "GL_HIGH_FLOAT")]
        HighFloat = 0x8DF2,
        [NativeName("Name", "GL_LOW_INT")]
        LowInt = 0x8DF3,
        [NativeName("Name", "GL_MEDIUM_INT")]
        MediumInt = 0x8DF4,
        [NativeName("Name", "GL_HIGH_INT")]
        HighInt = 0x8DF5,
    }
}
