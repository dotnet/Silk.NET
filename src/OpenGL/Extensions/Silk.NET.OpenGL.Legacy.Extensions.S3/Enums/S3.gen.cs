// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.S3
{
    [NativeName("Name", "GLenum")]
    public enum S3
    {
        [NativeName("Name", "GL_RGB_S3TC")]
        RgbS3TC = 0x83A0,
        [NativeName("Name", "GL_RGB4_S3TC")]
        Rgb4S3TC = 0x83A1,
        [NativeName("Name", "GL_RGBA_S3TC")]
        RgbaS3TC = 0x83A2,
        [NativeName("Name", "GL_RGBA4_S3TC")]
        Rgba4S3TC = 0x83A3,
        [NativeName("Name", "GL_RGBA_DXT5_S3TC")]
        RgbaDxt5S3TC = 0x83A4,
        [NativeName("Name", "GL_RGBA4_DXT5_S3TC")]
        Rgba4Dxt5S3TC = 0x83A5,
    }
}
