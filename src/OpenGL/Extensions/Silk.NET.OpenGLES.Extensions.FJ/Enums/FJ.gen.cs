// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.FJ
{
    [NativeName("Name", "GLenum")]
    public enum FJ : int
    {
        [NativeName("Name", "GL_GCCSO_SHADER_BINARY_FJ")]
        GccsoShaderBinaryFJ = 0x9260,
    }
}
