// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "RenderingMode")]
    public enum RenderingMode : int
    {
        [NativeName("Name", "GL_RENDER")]
        Render = 0x1C00,
        [NativeName("Name", "GL_FEEDBACK")]
        Feedback = 0x1C01,
        [NativeName("Name", "GL_SELECT")]
        Select = 0x1C02,
    }
}
