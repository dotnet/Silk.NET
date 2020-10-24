// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SeparableTarget")]
    public enum SeparableTarget
    {
        [NativeName("Name", "GL_SEPARABLE_2D")]
        Separable2D = 0x8012,
    }
}
