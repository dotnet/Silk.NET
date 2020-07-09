// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ShadingModel")]
    public enum ShadingModel
    {
        [NativeName("Name", "GL_FLAT")]
        Flat = 0x1D00,
        [NativeName("Name", "GL_SMOOTH")]
        Smooth = 0x1D01,
    }
}
