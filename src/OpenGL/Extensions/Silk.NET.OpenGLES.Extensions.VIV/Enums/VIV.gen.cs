// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.VIV
{
    [NativeName("Name", "GLenum")]
    public enum VIV : int
    {
        [NativeName("Name", "GL_SHADER_BINARY_VIV")]
        ShaderBinaryViv = 0x8FC4,
    }
}
