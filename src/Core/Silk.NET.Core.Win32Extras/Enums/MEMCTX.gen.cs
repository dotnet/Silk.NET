// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagMEMCTX")]
    public enum MEMCTX : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Task\"")]
        [NativeName("Name", "MEMCTX_TASK")]
        MemctxTask = 0x1,
        [Obsolete("Deprecated in favour of \"Shared\"")]
        [NativeName("Name", "MEMCTX_SHARED")]
        MemctxShared = 0x2,
        [Obsolete("Deprecated in favour of \"Macsystem\"")]
        [NativeName("Name", "MEMCTX_MACSYSTEM")]
        MemctxMacsystem = 0x3,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "MEMCTX_UNKNOWN")]
        MemctxUnknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Same\"")]
        [NativeName("Name", "MEMCTX_SAME")]
        MemctxSame = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "MEMCTX_TASK")]
        Task = 0x1,
        [NativeName("Name", "MEMCTX_SHARED")]
        Shared = 0x2,
        [NativeName("Name", "MEMCTX_MACSYSTEM")]
        Macsystem = 0x3,
        [NativeName("Name", "MEMCTX_UNKNOWN")]
        Unknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "MEMCTX_SAME")]
        Same = unchecked((int) 0xFFFFFFFFFFFFFFFE),
    }
}
