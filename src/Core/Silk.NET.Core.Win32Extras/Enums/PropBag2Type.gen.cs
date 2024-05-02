// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagPROPBAG2_TYPE")]
    public enum PropBag2Type : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "PROPBAG2_TYPE_UNDEFINED")]
        Propbag2TypeUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Data\"")]
        [NativeName("Name", "PROPBAG2_TYPE_DATA")]
        Propbag2TypeData = 0x1,
        [Obsolete("Deprecated in favour of \"Url\"")]
        [NativeName("Name", "PROPBAG2_TYPE_URL")]
        Propbag2TypeUrl = 0x2,
        [Obsolete("Deprecated in favour of \"Object\"")]
        [NativeName("Name", "PROPBAG2_TYPE_OBJECT")]
        Propbag2TypeObject = 0x3,
        [Obsolete("Deprecated in favour of \"Stream\"")]
        [NativeName("Name", "PROPBAG2_TYPE_STREAM")]
        Propbag2TypeStream = 0x4,
        [Obsolete("Deprecated in favour of \"Storage\"")]
        [NativeName("Name", "PROPBAG2_TYPE_STORAGE")]
        Propbag2TypeStorage = 0x5,
        [Obsolete("Deprecated in favour of \"Moniker\"")]
        [NativeName("Name", "PROPBAG2_TYPE_MONIKER")]
        Propbag2TypeMoniker = 0x6,
        [NativeName("Name", "PROPBAG2_TYPE_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "PROPBAG2_TYPE_DATA")]
        Data = 0x1,
        [NativeName("Name", "PROPBAG2_TYPE_URL")]
        Url = 0x2,
        [NativeName("Name", "PROPBAG2_TYPE_OBJECT")]
        Object = 0x3,
        [NativeName("Name", "PROPBAG2_TYPE_STREAM")]
        Stream = 0x4,
        [NativeName("Name", "PROPBAG2_TYPE_STORAGE")]
        Storage = 0x5,
        [NativeName("Name", "PROPBAG2_TYPE_MONIKER")]
        Moniker = 0x6,
    }
}
