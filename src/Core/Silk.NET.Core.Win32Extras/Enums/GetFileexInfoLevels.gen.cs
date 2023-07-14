// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_GET_FILEEX_INFO_LEVELS")]
    public enum GetFileexInfoLevels : int
    {
        [Obsolete("Deprecated in favour of \"InfoStandard\"")]
        [NativeName("Name", "GetFileExInfoStandard")]
        GetFileExInfoStandard = 0x0,
        [Obsolete("Deprecated in favour of \"MaxInfoLevel\"")]
        [NativeName("Name", "GetFileExMaxInfoLevel")]
        GetFileExMaxInfoLevel = 0x1,
        [NativeName("Name", "GetFileExInfoStandard")]
        InfoStandard = 0x0,
        [NativeName("Name", "GetFileExMaxInfoLevel")]
        MaxInfoLevel = 0x1,
    }
}
