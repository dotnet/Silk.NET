// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("AnonymousName", "__AnonymousEnum_evntrace_L887_C9")]
    [NativeName("Name", "ETW_COMPRESSION_RESUMPTION_MODE")]
    public enum EtwCompressionResumptionMode : int
    {
        [Obsolete("Deprecated in favour of \"Restart\"")]
        [NativeName("Name", "EtwCompressionModeRestart")]
        EtwCompressionModeRestart = 0x0,
        [Obsolete("Deprecated in favour of \"NoDisable\"")]
        [NativeName("Name", "EtwCompressionModeNoDisable")]
        EtwCompressionModeNoDisable = 0x1,
        [Obsolete("Deprecated in favour of \"NoRestart\"")]
        [NativeName("Name", "EtwCompressionModeNoRestart")]
        EtwCompressionModeNoRestart = 0x2,
        [NativeName("Name", "EtwCompressionModeRestart")]
        Restart = 0x0,
        [NativeName("Name", "EtwCompressionModeNoDisable")]
        NoDisable = 0x1,
        [NativeName("Name", "EtwCompressionModeNoRestart")]
        NoRestart = 0x2,
    }
}
