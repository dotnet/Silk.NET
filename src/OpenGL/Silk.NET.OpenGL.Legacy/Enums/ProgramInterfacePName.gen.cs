// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ProgramInterfacePName")]
    public enum ProgramInterfacePName : int
    {
        [NativeName("Name", "GL_ACTIVE_RESOURCES")]
        ActiveResources = 0x92F5,
        [NativeName("Name", "GL_MAX_NAME_LENGTH")]
        MaxNameLength = 0x92F6,
        [NativeName("Name", "GL_MAX_NUM_ACTIVE_VARIABLES")]
        MaxNumActiveVariables = 0x92F7,
        [NativeName("Name", "GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
        MaxNumCompatibleSubroutines = 0x92F8,
    }
}
