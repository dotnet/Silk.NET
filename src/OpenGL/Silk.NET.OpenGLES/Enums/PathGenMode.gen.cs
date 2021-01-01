// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathGenMode")]
    public enum PathGenMode : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_EYE_LINEAR")]
        EyeLinear = 0x2400,
        [NativeName("Name", "GL_OBJECT_LINEAR")]
        ObjectLinear = 0x2401,
        [NativeName("Name", "GL_CONSTANT")]
        Constant = 0x8576,
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        PathObjectBoundingBoxNV = 0x908A,
    }
}
