// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ShaderBinaryFormat")]
    public enum ShaderBinaryFormat
    {
        [NativeName("Name", "GL_SHADER_BINARY_FORMAT_SPIR_V")]
        ShaderBinaryFormatSpirV = 0x9551,
    }
}
