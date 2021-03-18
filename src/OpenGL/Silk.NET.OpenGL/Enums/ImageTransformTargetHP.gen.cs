// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ImageTransformTargetHP")]
    public enum ImageTransformTargetHP : int
    {
        [NativeName("Name", "GL_IMAGE_TRANSFORM_2D_HP")]
        ImageTransform2DHP = 0x8161,
    }
}
