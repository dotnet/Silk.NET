// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClipControlDepth")]
    public enum ClipControlDepth
    {
        [NativeName("Name", "GL_NEGATIVE_ONE_TO_ONE")]
        NegativeOneToOne = 0x935E,
        [NativeName("Name", "GL_ZERO_TO_ONE")]
        ZeroToOne = 0x935F,
    }
}
