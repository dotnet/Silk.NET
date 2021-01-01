// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FeedbackType")]
    public enum FeedbackType : int
    {
        [NativeName("Name", "GL_2D")]
        Gl2D = 0x600,
        [NativeName("Name", "GL_3D")]
        Gl3D = 0x601,
        [NativeName("Name", "GL_3D_COLOR")]
        Gl3DColor = 0x602,
        [NativeName("Name", "GL_3D_COLOR_TEXTURE")]
        Gl3DColorTexture = 0x603,
        [NativeName("Name", "GL_4D_COLOR_TEXTURE")]
        Gl4DColorTexture = 0x604,
    }
}
