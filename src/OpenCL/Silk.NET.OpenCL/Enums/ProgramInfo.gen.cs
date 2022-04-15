// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_program_info")]
    public enum ProgramInfo : int
    {
        [NativeName("Name", "CL_PROGRAM_REFERENCE_COUNT")]
        ProgramReferenceCount = 0x1160,
        [NativeName("Name", "CL_PROGRAM_CONTEXT")]
        ProgramContext = 0x1161,
        [NativeName("Name", "CL_PROGRAM_NUM_DEVICES")]
        ProgramNumDevices = 0x1162,
        [NativeName("Name", "CL_PROGRAM_DEVICES")]
        ProgramDevices = 0x1163,
        [NativeName("Name", "CL_PROGRAM_SOURCE")]
        ProgramSource = 0x1164,
        [NativeName("Name", "CL_PROGRAM_BINARY_SIZES")]
        ProgramBinarySizes = 0x1165,
        [NativeName("Name", "CL_PROGRAM_BINARIES")]
        ProgramBinaries = 0x1166,
        [NativeName("Name", "CL_PROGRAM_NUM_KERNELS")]
        ProgramNumKernels = 0x1167,
        [NativeName("Name", "CL_PROGRAM_KERNEL_NAMES")]
        ProgramKernelNames = 0x1168,
        [NativeName("Name", "CL_PROGRAM_IL")]
        ProgramIL = 0x1169,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
        ProgramScopeGlobalCtorsPresent = 0x116A,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
        ProgramScopeGlobalDtorsPresent = 0x116B,
        [NativeName("Name", "CL_PROGRAM_IL_KHR")]
        ProgramILKhr = 0x1169,
    }
}
