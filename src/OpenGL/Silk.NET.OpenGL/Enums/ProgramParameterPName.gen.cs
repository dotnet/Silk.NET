// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ProgramParameterPName")]
    public enum ProgramParameterPName : int
    {
        [Obsolete("Deprecated in favour of \"BinaryRetrievableHint\"")]
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        ProgramBinaryRetrievableHint = 0x8257,
        [Obsolete("Deprecated in favour of \"Separable\"")]
        [NativeName("Name", "GL_PROGRAM_SEPARABLE")]
        ProgramSeparable = 0x8258,
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        BinaryRetrievableHint = 0x8257,
        [NativeName("Name", "GL_PROGRAM_SEPARABLE")]
        Separable = 0x8258,
    }
}
