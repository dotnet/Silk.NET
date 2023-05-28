// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_STREAM_INFO_LEVELS")]
    public enum StreamInfoLevels : int
    {
        [Obsolete("Deprecated in favour of \"Standard\"")]
        [NativeName("Name", "FindStreamInfoStandard")]
        FindStreamInfoStandard = 0x0,
        [Obsolete("Deprecated in favour of \"MaxInfoLevel\"")]
        [NativeName("Name", "FindStreamInfoMaxInfoLevel")]
        FindStreamInfoMaxInfoLevel = 0x1,
        [NativeName("Name", "FindStreamInfoStandard")]
        Standard = 0x0,
        [NativeName("Name", "FindStreamInfoMaxInfoLevel")]
        MaxInfoLevel = 0x1,
    }
}
