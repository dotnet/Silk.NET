// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_context_properties")]
    public enum ContextProperties : ulong
    {
        [NativeName("Name", "CL_CONTEXT_PLATFORM")]
        Platform = 0x1084,
        [NativeName("Name", "CL_CONTEXT_INTEROP_USER_SYNC")]
        InteropUserSync = 0x1085,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        TerminateKhr = 0x2032,
        [NativeName("Name", "CL_PRINTF_CALLBACK_ARM")]
        PrintfCallbackArm = 0x40B0,
        [NativeName("Name", "CL_PRINTF_BUFFERSIZE_ARM")]
        PrintfBuffersizeArm = 0x40B1,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        DiagnosticsLevelAllIntel = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        DiagnosticsLevelGoodIntel = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        DiagnosticsLevelBadIntel = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        DiagnosticsLevelNeutralIntel = 0x4,
    }
}
