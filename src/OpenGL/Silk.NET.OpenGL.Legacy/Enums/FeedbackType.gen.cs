// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FeedbackType")]
    public enum FeedbackType : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_2D")]
        Gl2D = 0x600,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_3D")]
        Gl3D = 0x601,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_3D_COLOR")]
        Gl3DColor = 0x602,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_3D_COLOR_TEXTURE")]
        Gl3DColorTexture = 0x603,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_4D_COLOR_TEXTURE")]
        Gl4DColorTexture = 0x604,
    }
}
