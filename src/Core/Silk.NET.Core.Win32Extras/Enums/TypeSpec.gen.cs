// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagTYSPEC")]
    public enum TypeSpec : int
    {
        [Obsolete("Deprecated in favour of \"Clsid\"")]
        [NativeName("Name", "TYSPEC_CLSID")]
        TyspecClsid = 0x0,
        [Obsolete("Deprecated in favour of \"Fileext\"")]
        [NativeName("Name", "TYSPEC_FILEEXT")]
        TyspecFileext = 0x1,
        [Obsolete("Deprecated in favour of \"Mimetype\"")]
        [NativeName("Name", "TYSPEC_MIMETYPE")]
        TyspecMimetype = 0x2,
        [Obsolete("Deprecated in favour of \"Filename\"")]
        [NativeName("Name", "TYSPEC_FILENAME")]
        TyspecFilename = 0x3,
        [Obsolete("Deprecated in favour of \"Progid\"")]
        [NativeName("Name", "TYSPEC_PROGID")]
        TyspecProgid = 0x4,
        [Obsolete("Deprecated in favour of \"Packagename\"")]
        [NativeName("Name", "TYSPEC_PACKAGENAME")]
        TyspecPackagename = 0x5,
        [Obsolete("Deprecated in favour of \"Objectid\"")]
        [NativeName("Name", "TYSPEC_OBJECTID")]
        TyspecObjectid = 0x6,
        [NativeName("Name", "TYSPEC_CLSID")]
        Clsid = 0x0,
        [NativeName("Name", "TYSPEC_FILEEXT")]
        Fileext = 0x1,
        [NativeName("Name", "TYSPEC_MIMETYPE")]
        Mimetype = 0x2,
        [NativeName("Name", "TYSPEC_FILENAME")]
        Filename = 0x3,
        [NativeName("Name", "TYSPEC_PROGID")]
        Progid = 0x4,
        [NativeName("Name", "TYSPEC_PACKAGENAME")]
        Packagename = 0x5,
        [NativeName("Name", "TYSPEC_OBJECTID")]
        Objectid = 0x6,
    }
}
