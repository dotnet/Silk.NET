// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FfdMaskSGIX")]
    public enum FfdMaskSGIX
    {
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_BIT_SGIX")]
        TextureDeformationBitSgix = 0x1,
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
        GeometryDeformationBitSgix = 0x2,
    }
}
