// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "MatrixMode")]
    public enum MatrixMode : int
    {
        [NativeName("Name", "GL_MODELVIEW0_EXT")]
        Modelview0Ext = 0x1700,
        [NativeName("Name", "GL_TEXTURE")]
        Texture = 0x1702,
    }
}
