// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICSectionAccessLevel")]
    public enum SectionAccessLevel : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WICSectionAccessLevelRead")]
        Read = 0x1,
        [NativeName("Name", "WICSectionAccessLevelReadWrite")]
        ReadWrite = 0x3,
        [NativeName("Name", "WICSectionAccessLevel_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
