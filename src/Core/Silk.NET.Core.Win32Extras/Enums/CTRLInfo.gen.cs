// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagCTRLINFO")]
    public enum CTRLInfo : int
    {
        [Obsolete("Deprecated in favour of \"Return\"")]
        [NativeName("Name", "CTRLINFO_EATS_RETURN")]
        CtrlinfoEatsReturn = 0x1,
        [Obsolete("Deprecated in favour of \"Escape\"")]
        [NativeName("Name", "CTRLINFO_EATS_ESCAPE")]
        CtrlinfoEatsEscape = 0x2,
        [NativeName("Name", "CTRLINFO_EATS_RETURN")]
        Return = 0x1,
        [NativeName("Name", "CTRLINFO_EATS_ESCAPE")]
        Escape = 0x2,
    }
}
