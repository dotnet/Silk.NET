// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICSectionAccessLevel")]
    public enum WICSectionAccessLevel : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "WICSectionAccessLevelRead")]
        WicsectionAccessLevelRead = 0x1,
        [Obsolete("Deprecated in favour of \"ReadWrite\"")]
        [NativeName("Name", "WICSectionAccessLevelReadWrite")]
        WicsectionAccessLevelReadWrite = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "WICSectionAccessLevel_FORCE_DWORD")]
        WicsectionAccessLevelForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICSectionAccessLevelRead")]
        Read = 0x1,
        [NativeName("Name", "WICSectionAccessLevelReadWrite")]
        ReadWrite = 0x3,
        [NativeName("Name", "WICSectionAccessLevel_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
