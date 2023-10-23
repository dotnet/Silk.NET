// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagMKSYS")]
    public enum MKSYS : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "MKSYS_NONE")]
        MksysNone = 0x0,
        [Obsolete("Deprecated in favour of \"Genericcomposite\"")]
        [NativeName("Name", "MKSYS_GENERICCOMPOSITE")]
        MksysGenericcomposite = 0x1,
        [Obsolete("Deprecated in favour of \"Filemoniker\"")]
        [NativeName("Name", "MKSYS_FILEMONIKER")]
        MksysFilemoniker = 0x2,
        [Obsolete("Deprecated in favour of \"Antimoniker\"")]
        [NativeName("Name", "MKSYS_ANTIMONIKER")]
        MksysAntimoniker = 0x3,
        [Obsolete("Deprecated in favour of \"Itemmoniker\"")]
        [NativeName("Name", "MKSYS_ITEMMONIKER")]
        MksysItemmoniker = 0x4,
        [Obsolete("Deprecated in favour of \"Pointermoniker\"")]
        [NativeName("Name", "MKSYS_POINTERMONIKER")]
        MksysPointermoniker = 0x5,
        [Obsolete("Deprecated in favour of \"Classmoniker\"")]
        [NativeName("Name", "MKSYS_CLASSMONIKER")]
        MksysClassmoniker = 0x7,
        [Obsolete("Deprecated in favour of \"Objrefmoniker\"")]
        [NativeName("Name", "MKSYS_OBJREFMONIKER")]
        MksysObjrefmoniker = 0x8,
        [Obsolete("Deprecated in favour of \"Sessionmoniker\"")]
        [NativeName("Name", "MKSYS_SESSIONMONIKER")]
        MksysSessionmoniker = 0x9,
        [Obsolete("Deprecated in favour of \"Luamoniker\"")]
        [NativeName("Name", "MKSYS_LUAMONIKER")]
        MksysLuamoniker = 0xA,
        [NativeName("Name", "MKSYS_NONE")]
        None = 0x0,
        [NativeName("Name", "MKSYS_GENERICCOMPOSITE")]
        Genericcomposite = 0x1,
        [NativeName("Name", "MKSYS_FILEMONIKER")]
        Filemoniker = 0x2,
        [NativeName("Name", "MKSYS_ANTIMONIKER")]
        Antimoniker = 0x3,
        [NativeName("Name", "MKSYS_ITEMMONIKER")]
        Itemmoniker = 0x4,
        [NativeName("Name", "MKSYS_POINTERMONIKER")]
        Pointermoniker = 0x5,
        [NativeName("Name", "MKSYS_CLASSMONIKER")]
        Classmoniker = 0x7,
        [NativeName("Name", "MKSYS_OBJREFMONIKER")]
        Objrefmoniker = 0x8,
        [NativeName("Name", "MKSYS_SESSIONMONIKER")]
        Sessionmoniker = 0x9,
        [NativeName("Name", "MKSYS_LUAMONIKER")]
        Luamoniker = 0xA,
    }
}
