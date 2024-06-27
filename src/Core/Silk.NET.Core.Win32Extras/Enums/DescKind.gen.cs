// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagDESCKIND")]
    public enum DescKind : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DESCKIND_NONE")]
        DesckindNone = 0x0,
        [Obsolete("Deprecated in favour of \"Funcdesc\"")]
        [NativeName("Name", "DESCKIND_FUNCDESC")]
        DesckindFuncdesc = 0x1,
        [Obsolete("Deprecated in favour of \"Vardesc\"")]
        [NativeName("Name", "DESCKIND_VARDESC")]
        DesckindVardesc = 0x2,
        [Obsolete("Deprecated in favour of \"Typecomp\"")]
        [NativeName("Name", "DESCKIND_TYPECOMP")]
        DesckindTypecomp = 0x3,
        [Obsolete("Deprecated in favour of \"Implicitappobj\"")]
        [NativeName("Name", "DESCKIND_IMPLICITAPPOBJ")]
        DesckindImplicitappobj = 0x4,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "DESCKIND_MAX")]
        DesckindMax = 0x5,
        [NativeName("Name", "DESCKIND_NONE")]
        None = 0x0,
        [NativeName("Name", "DESCKIND_FUNCDESC")]
        Funcdesc = 0x1,
        [NativeName("Name", "DESCKIND_VARDESC")]
        Vardesc = 0x2,
        [NativeName("Name", "DESCKIND_TYPECOMP")]
        Typecomp = 0x3,
        [NativeName("Name", "DESCKIND_IMPLICITAPPOBJ")]
        Implicitappobj = 0x4,
        [NativeName("Name", "DESCKIND_MAX")]
        Max = 0x5,
    }
}
