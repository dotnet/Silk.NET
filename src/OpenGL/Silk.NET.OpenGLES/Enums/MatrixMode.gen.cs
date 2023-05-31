// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MatrixMode")]
    public enum MatrixMode : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MODELVIEW")]
        Modelview = 0x1700,
        [NativeName("Name", "GL_MODELVIEW0_EXT")]
        Modelview0Ext = 0x1700,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PROJECTION")]
        Projection = 0x1701,
        [NativeName("Name", "GL_TEXTURE")]
        Texture = 0x1702,
    }
}
