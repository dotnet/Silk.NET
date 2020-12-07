// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FrontFaceDirection")]
    public enum FrontFaceDirection
    {
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
    }
}
