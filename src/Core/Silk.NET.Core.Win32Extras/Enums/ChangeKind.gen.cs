// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagCHANGEKIND")]
    public enum ChangeKind : int
    {
        [Obsolete("Deprecated in favour of \"Addmember\"")]
        [NativeName("Name", "CHANGEKIND_ADDMEMBER")]
        ChangekindAddmember = 0x0,
        [Obsolete("Deprecated in favour of \"Deletemember\"")]
        [NativeName("Name", "CHANGEKIND_DELETEMEMBER")]
        ChangekindDeletemember = 0x1,
        [Obsolete("Deprecated in favour of \"Setnames\"")]
        [NativeName("Name", "CHANGEKIND_SETNAMES")]
        ChangekindSetnames = 0x2,
        [Obsolete("Deprecated in favour of \"Setdocumentation\"")]
        [NativeName("Name", "CHANGEKIND_SETDOCUMENTATION")]
        ChangekindSetdocumentation = 0x3,
        [Obsolete("Deprecated in favour of \"General\"")]
        [NativeName("Name", "CHANGEKIND_GENERAL")]
        ChangekindGeneral = 0x4,
        [Obsolete("Deprecated in favour of \"Invalidate\"")]
        [NativeName("Name", "CHANGEKIND_INVALIDATE")]
        ChangekindInvalidate = 0x5,
        [Obsolete("Deprecated in favour of \"Changefailed\"")]
        [NativeName("Name", "CHANGEKIND_CHANGEFAILED")]
        ChangekindChangefailed = 0x6,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "CHANGEKIND_MAX")]
        ChangekindMax = 0x7,
        [NativeName("Name", "CHANGEKIND_ADDMEMBER")]
        Addmember = 0x0,
        [NativeName("Name", "CHANGEKIND_DELETEMEMBER")]
        Deletemember = 0x1,
        [NativeName("Name", "CHANGEKIND_SETNAMES")]
        Setnames = 0x2,
        [NativeName("Name", "CHANGEKIND_SETDOCUMENTATION")]
        Setdocumentation = 0x3,
        [NativeName("Name", "CHANGEKIND_GENERAL")]
        General = 0x4,
        [NativeName("Name", "CHANGEKIND_INVALIDATE")]
        Invalidate = 0x5,
        [NativeName("Name", "CHANGEKIND_CHANGEFAILED")]
        Changefailed = 0x6,
        [NativeName("Name", "CHANGEKIND_MAX")]
        Max = 0x7,
    }
}
