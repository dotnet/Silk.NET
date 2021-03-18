// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
