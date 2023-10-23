// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagCALLTYPE")]
    public enum CallType : int
    {
        [Obsolete("Deprecated in favour of \"Toplevel\"")]
        [NativeName("Name", "CALLTYPE_TOPLEVEL")]
        CalltypeToplevel = 0x1,
        [Obsolete("Deprecated in favour of \"Nested\"")]
        [NativeName("Name", "CALLTYPE_NESTED")]
        CalltypeNested = 0x2,
        [Obsolete("Deprecated in favour of \"Async\"")]
        [NativeName("Name", "CALLTYPE_ASYNC")]
        CalltypeAsync = 0x3,
        [Obsolete("Deprecated in favour of \"ToplevelCallpending\"")]
        [NativeName("Name", "CALLTYPE_TOPLEVEL_CALLPENDING")]
        CalltypeToplevelCallpending = 0x4,
        [Obsolete("Deprecated in favour of \"AsyncCallpending\"")]
        [NativeName("Name", "CALLTYPE_ASYNC_CALLPENDING")]
        CalltypeAsyncCallpending = 0x5,
        [NativeName("Name", "CALLTYPE_TOPLEVEL")]
        Toplevel = 0x1,
        [NativeName("Name", "CALLTYPE_NESTED")]
        Nested = 0x2,
        [NativeName("Name", "CALLTYPE_ASYNC")]
        Async = 0x3,
        [NativeName("Name", "CALLTYPE_TOPLEVEL_CALLPENDING")]
        ToplevelCallpending = 0x4,
        [NativeName("Name", "CALLTYPE_ASYNC_CALLPENDING")]
        AsyncCallpending = 0x5,
    }
}
