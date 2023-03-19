// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_THDTYPE")]
    public enum Thdtype : int
    {
        [Obsolete("Deprecated in favour of \"Blockmessages\"")]
        [NativeName("Name", "THDTYPE_BLOCKMESSAGES")]
        ThdtypeBlockmessages = 0x0,
        [Obsolete("Deprecated in favour of \"Processmessages\"")]
        [NativeName("Name", "THDTYPE_PROCESSMESSAGES")]
        ThdtypeProcessmessages = 0x1,
        [NativeName("Name", "THDTYPE_BLOCKMESSAGES")]
        Blockmessages = 0x0,
        [NativeName("Name", "THDTYPE_PROCESSMESSAGES")]
        Processmessages = 0x1,
    }
}
