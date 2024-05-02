// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagTYPEKIND")]
    public enum TypeKind : int
    {
        [Obsolete("Deprecated in favour of \"Enum\"")]
        [NativeName("Name", "TKIND_ENUM")]
        TkindEnum = 0x0,
        [Obsolete("Deprecated in favour of \"Record\"")]
        [NativeName("Name", "TKIND_RECORD")]
        TkindRecord = 0x1,
        [Obsolete("Deprecated in favour of \"Module\"")]
        [NativeName("Name", "TKIND_MODULE")]
        TkindModule = 0x2,
        [Obsolete("Deprecated in favour of \"Interface\"")]
        [NativeName("Name", "TKIND_INTERFACE")]
        TkindInterface = 0x3,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "TKIND_DISPATCH")]
        TkindDispatch = 0x4,
        [Obsolete("Deprecated in favour of \"Coclass\"")]
        [NativeName("Name", "TKIND_COCLASS")]
        TkindCoclass = 0x5,
        [Obsolete("Deprecated in favour of \"Alias\"")]
        [NativeName("Name", "TKIND_ALIAS")]
        TkindAlias = 0x6,
        [Obsolete("Deprecated in favour of \"Union\"")]
        [NativeName("Name", "TKIND_UNION")]
        TkindUnion = 0x7,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "TKIND_MAX")]
        TkindMax = 0x8,
        [NativeName("Name", "TKIND_ENUM")]
        Enum = 0x0,
        [NativeName("Name", "TKIND_RECORD")]
        Record = 0x1,
        [NativeName("Name", "TKIND_MODULE")]
        Module = 0x2,
        [NativeName("Name", "TKIND_INTERFACE")]
        Interface = 0x3,
        [NativeName("Name", "TKIND_DISPATCH")]
        Dispatch = 0x4,
        [NativeName("Name", "TKIND_COCLASS")]
        Coclass = 0x5,
        [NativeName("Name", "TKIND_ALIAS")]
        Alias = 0x6,
        [NativeName("Name", "TKIND_UNION")]
        Union = 0x7,
        [NativeName("Name", "TKIND_MAX")]
        Max = 0x8,
    }
}
