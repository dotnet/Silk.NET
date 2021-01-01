// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ObjectTypeAPPLE")]
    public enum ObjectTypeAPPLE : int
    {
        [NativeName("Name", "GL_DRAW_PIXELS_APPLE")]
        DrawPixelsApple = 0x8A0A,
        [NativeName("Name", "GL_FENCE_APPLE")]
        FenceApple = 0x8A0B,
    }
}
