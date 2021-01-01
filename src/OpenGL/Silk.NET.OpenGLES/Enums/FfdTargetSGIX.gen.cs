// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FfdTargetSGIX")]
    public enum FfdTargetSGIX : int
    {
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_SGIX")]
        GeometryDeformationSgix = 0x8194,
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_SGIX")]
        TextureDeformationSgix = 0x8195,
    }
}
