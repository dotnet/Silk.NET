// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "VertexShaderParameterEXT")]
    public enum VertexShaderParameterEXT : int
    {
        [NativeName("Name", "GL_CURRENT_VERTEX_EXT")]
        CurrentVertexExt = 0x87E2,
        [NativeName("Name", "GL_MVP_MATRIX_EXT")]
        MvpMatrixExt = 0x87E3,
    }
}
