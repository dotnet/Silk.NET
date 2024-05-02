// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagFUNCKIND")]
    public enum FuncKind : int
    {
        [Obsolete("Deprecated in favour of \"Virtual\"")]
        [NativeName("Name", "FUNC_VIRTUAL")]
        FuncVirtual = 0x0,
        [Obsolete("Deprecated in favour of \"Purevirtual\"")]
        [NativeName("Name", "FUNC_PUREVIRTUAL")]
        FuncPurevirtual = 0x1,
        [Obsolete("Deprecated in favour of \"Nonvirtual\"")]
        [NativeName("Name", "FUNC_NONVIRTUAL")]
        FuncNonvirtual = 0x2,
        [Obsolete("Deprecated in favour of \"Static\"")]
        [NativeName("Name", "FUNC_STATIC")]
        FuncStatic = 0x3,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "FUNC_DISPATCH")]
        FuncDispatch = 0x4,
        [NativeName("Name", "FUNC_VIRTUAL")]
        Virtual = 0x0,
        [NativeName("Name", "FUNC_PUREVIRTUAL")]
        Purevirtual = 0x1,
        [NativeName("Name", "FUNC_NONVIRTUAL")]
        Nonvirtual = 0x2,
        [NativeName("Name", "FUNC_STATIC")]
        Static = 0x3,
        [NativeName("Name", "FUNC_DISPATCH")]
        Dispatch = 0x4,
    }
}
