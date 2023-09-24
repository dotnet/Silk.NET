// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSTGTY")]
    public enum STGTY : int
    {
        [Obsolete("Deprecated in favour of \"Storage\"")]
        [NativeName("Name", "STGTY_STORAGE")]
        StgtyStorage = 0x1,
        [Obsolete("Deprecated in favour of \"Stream\"")]
        [NativeName("Name", "STGTY_STREAM")]
        StgtyStream = 0x2,
        [Obsolete("Deprecated in favour of \"Lockbytes\"")]
        [NativeName("Name", "STGTY_LOCKBYTES")]
        StgtyLockbytes = 0x3,
        [Obsolete("Deprecated in favour of \"Property\"")]
        [NativeName("Name", "STGTY_PROPERTY")]
        StgtyProperty = 0x4,
        [NativeName("Name", "STGTY_STORAGE")]
        Storage = 0x1,
        [NativeName("Name", "STGTY_STREAM")]
        Stream = 0x2,
        [NativeName("Name", "STGTY_LOCKBYTES")]
        Lockbytes = 0x3,
        [NativeName("Name", "STGTY_PROPERTY")]
        Property = 0x4,
    }
}
