// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ClampColorTargetARB")]
    public enum ClampColorTargetARB : int
    {
        [NativeName("Name", "GL_CLAMP_VERTEX_COLOR_ARB")]
        ClampVertexColorArb = 0x891A,
        [NativeName("Name", "GL_CLAMP_FRAGMENT_COLOR_ARB")]
        ClampFragmentColorArb = 0x891B,
        [NativeName("Name", "GL_CLAMP_READ_COLOR")]
        ClampReadColor = 0x891C,
        [NativeName("Name", "GL_CLAMP_READ_COLOR_ARB")]
        ClampReadColorArb = 0x891C,
    }
}
