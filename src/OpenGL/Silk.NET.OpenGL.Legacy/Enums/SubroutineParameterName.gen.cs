// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SubroutineParameterName")]
    public enum SubroutineParameterName : int
    {
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [NativeName("Name", "GL_NUM_COMPATIBLE_SUBROUTINES")]
        NumCompatibleSubroutines = 0x8E4A,
        [NativeName("Name", "GL_COMPATIBLE_SUBROUTINES")]
        CompatibleSubroutines = 0x8E4B,
    }
}
