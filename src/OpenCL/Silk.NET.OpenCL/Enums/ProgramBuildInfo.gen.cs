// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_program_build_info")]
    public enum ProgramBuildInfo : int
    {
        [NativeName("Name", "CL_PROGRAM_BUILD_STATUS")]
        BuildStatus = 0x1181,
        [NativeName("Name", "CL_PROGRAM_BUILD_OPTIONS")]
        BuildOptions = 0x1182,
        [NativeName("Name", "CL_PROGRAM_BUILD_LOG")]
        BuildLog = 0x1183,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE")]
        BinaryType = 0x1184,
        [NativeName("Name", "CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE")]
        BuildGlobalVariableTotalSize = 0x1185,
    }
}
