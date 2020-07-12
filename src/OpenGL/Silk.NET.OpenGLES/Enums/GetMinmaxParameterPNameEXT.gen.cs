// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetMinmaxParameterPNameEXT")]
    public enum GetMinmaxParameterPNameEXT
    {
        [NativeName("Name", "GL_MINMAX_FORMAT")]
        MinmaxFormat = 0x802F,
        [NativeName("Name", "GL_MINMAX_FORMAT_EXT")]
        MinmaxFormatExt = 0x802F,
        [NativeName("Name", "GL_MINMAX_SINK")]
        MinmaxSink = 0x8030,
        [NativeName("Name", "GL_MINMAX_SINK_EXT")]
        MinmaxSinkExt = 0x8030,
    }
}
