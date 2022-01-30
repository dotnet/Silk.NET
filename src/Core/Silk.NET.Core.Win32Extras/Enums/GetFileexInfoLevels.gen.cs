// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_GET_FILEEX_INFO_LEVELS")]
    public enum GetFileexInfoLevels : int
    {
        [NativeName("Name", "GetFileExInfoStandard")]
        GetFileExInfoStandard = 0x0,
        [NativeName("Name", "GetFileExMaxInfoLevel")]
        GetFileExMaxInfoLevel = 0x1,
    }
}
