// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "__AnonymousEnum_evntrace_L529_C9")]
    public enum EtwCompressionResumptionMode : int
    {
        [NativeName("Name", "EtwCompressionModeRestart")]
        EtwCompressionModeRestart = 0x0,
        [NativeName("Name", "EtwCompressionModeNoDisable")]
        EtwCompressionModeNoDisable = 0x1,
        [NativeName("Name", "EtwCompressionModeNoRestart")]
        EtwCompressionModeNoRestart = 0x2,
    }
}
