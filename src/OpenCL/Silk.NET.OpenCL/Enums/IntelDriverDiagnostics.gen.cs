// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_intel_driver_diagnostics")]
    public enum IntelDriverDiagnostics : int
    {
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
        ContextDiagnosticsLevelAllIntel = 0xFF,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
        ContextDiagnosticsLevelGoodIntel = 0x1,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
        ContextDiagnosticsLevelBadIntel = 0x2,
        [NativeName("Name", "CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
        ContextDiagnosticsLevelNeutralIntel = 0x4,
    }
}
