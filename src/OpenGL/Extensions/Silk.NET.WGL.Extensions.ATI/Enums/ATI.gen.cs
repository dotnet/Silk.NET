// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.ATI
{
    [NativeName("Name", "GLenum")]
    public enum ATI : int
    {
        [NativeName("Name", "WGL_TYPE_RGBA_FLOAT_ATI")]
        TypeRgbaFloatAti = 0x21A0,
        [NativeName("Name", "WGL_TEXTURE_RECTANGLE_ATI")]
        TextureRectangleAti = 0x21A5,
    }
}
