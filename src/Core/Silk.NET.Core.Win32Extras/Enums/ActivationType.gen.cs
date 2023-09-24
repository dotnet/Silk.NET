// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagACTIVATIONTYPE")]
    public enum ActivationType : int
    {
        [Obsolete("Deprecated in favour of \"Uncategorized\"")]
        [NativeName("Name", "ACTIVATIONTYPE_UNCATEGORIZED")]
        ActivationtypeUncategorized = 0x0,
        [Obsolete("Deprecated in favour of \"FromMoniker\"")]
        [NativeName("Name", "ACTIVATIONTYPE_FROM_MONIKER")]
        ActivationtypeFromMoniker = 0x1,
        [Obsolete("Deprecated in favour of \"FromData\"")]
        [NativeName("Name", "ACTIVATIONTYPE_FROM_DATA")]
        ActivationtypeFromData = 0x2,
        [Obsolete("Deprecated in favour of \"FromStorage\"")]
        [NativeName("Name", "ACTIVATIONTYPE_FROM_STORAGE")]
        ActivationtypeFromStorage = 0x4,
        [Obsolete("Deprecated in favour of \"FromStream\"")]
        [NativeName("Name", "ACTIVATIONTYPE_FROM_STREAM")]
        ActivationtypeFromStream = 0x8,
        [Obsolete("Deprecated in favour of \"FromFile\"")]
        [NativeName("Name", "ACTIVATIONTYPE_FROM_FILE")]
        ActivationtypeFromFile = 0x10,
        [NativeName("Name", "ACTIVATIONTYPE_UNCATEGORIZED")]
        Uncategorized = 0x0,
        [NativeName("Name", "ACTIVATIONTYPE_FROM_MONIKER")]
        FromMoniker = 0x1,
        [NativeName("Name", "ACTIVATIONTYPE_FROM_DATA")]
        FromData = 0x2,
        [NativeName("Name", "ACTIVATIONTYPE_FROM_STORAGE")]
        FromStorage = 0x4,
        [NativeName("Name", "ACTIVATIONTYPE_FROM_STREAM")]
        FromStream = 0x8,
        [NativeName("Name", "ACTIVATIONTYPE_FROM_FILE")]
        FromFile = 0x10,
    }
}
