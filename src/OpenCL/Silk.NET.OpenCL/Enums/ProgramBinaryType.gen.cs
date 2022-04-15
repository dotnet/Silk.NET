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
        ProgramBinaryTypeNone = 0x0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
        ProgramBinaryTypeCompiledObject = 0x1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_LIBRARY")]
        ProgramBinaryTypeLibrary = 0x2,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
        ProgramBinaryTypeExecutable = 0x4,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        ProgramBinaryTypeIntermediate = 0x40E1,
    }
}
