// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexAttribEnumNV")]
    public enum VertexAttribEnumNV : int
    {
        [NativeName("Name", "GL_PROGRAM_PARAMETER_NV")]
        ProgramParameterNV = 0x8644,
    }
}
