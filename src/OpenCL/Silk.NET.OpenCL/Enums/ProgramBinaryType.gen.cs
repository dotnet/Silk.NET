// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_program_binary_type")]
    public enum ProgramBinaryType : int
    {
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
        CompiledObject = 0x1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_LIBRARY")]
        Library = 0x2,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
        Executable = 0x4,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        Intermediate = 0x40E1,
    }
}
