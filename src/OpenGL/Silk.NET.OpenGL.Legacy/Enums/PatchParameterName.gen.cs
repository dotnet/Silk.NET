// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PatchParameterName")]
    public enum PatchParameterName
    {
        [NativeName("Name", "GL_PATCH_VERTICES")]
        PatchVertices = 0x8E72,
        [NativeName("Name", "GL_PATCH_DEFAULT_INNER_LEVEL")]
        PatchDefaultInnerLevel = 0x8E73,
        [NativeName("Name", "GL_PATCH_DEFAULT_OUTER_LEVEL")]
        PatchDefaultOuterLevel = 0x8E74,
    }
}
