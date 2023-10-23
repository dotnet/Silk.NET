// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagDATADIR")]
    public enum DATADIR : int
    {
        [Obsolete("Deprecated in favour of \"Get\"")]
        [NativeName("Name", "DATADIR_GET")]
        DatadirGet = 0x1,
        [Obsolete("Deprecated in favour of \"Set\"")]
        [NativeName("Name", "DATADIR_SET")]
        DatadirSet = 0x2,
        [NativeName("Name", "DATADIR_GET")]
        Get = 0x1,
        [NativeName("Name", "DATADIR_SET")]
        Set = 0x2,
    }
}
