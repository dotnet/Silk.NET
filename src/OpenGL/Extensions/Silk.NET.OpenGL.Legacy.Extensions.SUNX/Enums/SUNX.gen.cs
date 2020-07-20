// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUNX
{
    [NativeName("Name", "GLenum")]
    public enum SUNX
    {
        [NativeName("Name", "GL_UNPACK_CONSTANT_DATA_SUNX")]
        UnpackConstantDataSunx = 0x81D5,
        [NativeName("Name", "GL_TEXTURE_CONSTANT_DATA_SUNX")]
        TextureConstantDataSunx = 0x81D6,
    }
}
