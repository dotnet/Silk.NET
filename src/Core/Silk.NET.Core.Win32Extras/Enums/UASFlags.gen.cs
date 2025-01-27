// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagUASFLAGS")]
    public enum UASFlags : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "UAS_NORMAL")]
        UasNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Blocked\"")]
        [NativeName("Name", "UAS_BLOCKED")]
        UasBlocked = 0x1,
        [Obsolete("Deprecated in favour of \"Noparentenable\"")]
        [NativeName("Name", "UAS_NOPARENTENABLE")]
        UasNoparentenable = 0x2,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "UAS_MASK")]
        UasMask = 0x3,
        [NativeName("Name", "UAS_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "UAS_BLOCKED")]
        Blocked = 0x1,
        [NativeName("Name", "UAS_NOPARENTENABLE")]
        Noparentenable = 0x2,
        [NativeName("Name", "UAS_MASK")]
        Mask = 0x3,
    }
}
