// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FfdMaskSGIX")]
    public enum FfdMaskSGIX : int
    {
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_BIT_SGIX")]
        TextureDeformationBitSgix = 0x1,
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
        GeometryDeformationBitSgix = 0x2,
    }
}
