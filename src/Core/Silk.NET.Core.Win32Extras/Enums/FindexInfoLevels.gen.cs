// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_FINDEX_INFO_LEVELS")]
    public enum FindexInfoLevels : int
    {
        [NativeName("Name", "FindExInfoStandard")]
        FindExInfoStandard = 0x0,
        [NativeName("Name", "FindExInfoBasic")]
        FindExInfoBasic = 0x1,
        [NativeName("Name", "FindExInfoMaxInfoLevel")]
        FindExInfoMaxInfoLevel = 0x2,
    }
}
