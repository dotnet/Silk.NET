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
        ReferenceCount = 0x1160,
        [NativeName("Name", "CL_PROGRAM_CONTEXT")]
        Context = 0x1161,
        [NativeName("Name", "CL_PROGRAM_NUM_DEVICES")]
        NumDevices = 0x1162,
        [NativeName("Name", "CL_PROGRAM_DEVICES")]
        Devices = 0x1163,
        [NativeName("Name", "CL_PROGRAM_SOURCE")]
        Source = 0x1164,
        [NativeName("Name", "CL_PROGRAM_BINARY_SIZES")]
        BinarySizes = 0x1165,
        [NativeName("Name", "CL_PROGRAM_BINARIES")]
        Binaries = 0x1166,
        [NativeName("Name", "CL_PROGRAM_NUM_KERNELS")]
        NumKernels = 0x1167,
        [NativeName("Name", "CL_PROGRAM_KERNEL_NAMES")]
        KernelNames = 0x1168,
        [NativeName("Name", "CL_PROGRAM_IL")]
        IL = 0x1169,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
        ScopeGlobalCtorsPresent = 0x116A,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
        ScopeGlobalDtorsPresent = 0x116B,
        [NativeName("Name", "CL_PROGRAM_IL_KHR")]
        ILKhr = 0x1169,
    }
}
