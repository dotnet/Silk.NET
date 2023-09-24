// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagTYMED")]
    public enum TYMED : int
    {
        [Obsolete("Deprecated in favour of \"Hglobal\"")]
        [NativeName("Name", "TYMED_HGLOBAL")]
        TymedHglobal = 0x1,
        [Obsolete("Deprecated in favour of \"File\"")]
        [NativeName("Name", "TYMED_FILE")]
        TymedFile = 0x2,
        [Obsolete("Deprecated in favour of \"Istream\"")]
        [NativeName("Name", "TYMED_ISTREAM")]
        TymedIstream = 0x4,
        [Obsolete("Deprecated in favour of \"Istorage\"")]
        [NativeName("Name", "TYMED_ISTORAGE")]
        TymedIstorage = 0x8,
        [Obsolete("Deprecated in favour of \"Gdi\"")]
        [NativeName("Name", "TYMED_GDI")]
        TymedGdi = 0x10,
        [Obsolete("Deprecated in favour of \"Mfpict\"")]
        [NativeName("Name", "TYMED_MFPICT")]
        TymedMfpict = 0x20,
        [Obsolete("Deprecated in favour of \"Enhmf\"")]
        [NativeName("Name", "TYMED_ENHMF")]
        TymedEnhmf = 0x40,
        [Obsolete("Deprecated in favour of \"Null\"")]
        [NativeName("Name", "TYMED_NULL")]
        TymedNull = 0x0,
        [NativeName("Name", "TYMED_HGLOBAL")]
        Hglobal = 0x1,
        [NativeName("Name", "TYMED_FILE")]
        File = 0x2,
        [NativeName("Name", "TYMED_ISTREAM")]
        Istream = 0x4,
        [NativeName("Name", "TYMED_ISTORAGE")]
        Istorage = 0x8,
        [NativeName("Name", "TYMED_GDI")]
        Gdi = 0x10,
        [NativeName("Name", "TYMED_MFPICT")]
        Mfpict = 0x20,
        [NativeName("Name", "TYMED_ENHMF")]
        Enhmf = 0x40,
        [NativeName("Name", "TYMED_NULL")]
        Null = 0x0,
    }
}
