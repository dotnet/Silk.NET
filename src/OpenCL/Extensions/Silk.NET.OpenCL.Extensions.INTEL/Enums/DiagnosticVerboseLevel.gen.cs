// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [System.Flags]
    [NativeName("Name", "cl_diagnostic_verbose_level_intel")]
    public enum DiagnosticVerboseLevel : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        All = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        Good = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        Bad = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        Neutral = 0x4,
    }
}
