// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagVARKIND")]
    public enum VarKind : int
    {
        [Obsolete("Deprecated in favour of \"Perinstance\"")]
        [NativeName("Name", "VAR_PERINSTANCE")]
        VarPerinstance = 0x0,
        [Obsolete("Deprecated in favour of \"Static\"")]
        [NativeName("Name", "VAR_STATIC")]
        VarStatic = 0x1,
        [Obsolete("Deprecated in favour of \"Const\"")]
        [NativeName("Name", "VAR_CONST")]
        VarConst = 0x2,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "VAR_DISPATCH")]
        VarDispatch = 0x3,
        [NativeName("Name", "VAR_PERINSTANCE")]
        Perinstance = 0x0,
        [NativeName("Name", "VAR_STATIC")]
        Static = 0x1,
        [NativeName("Name", "VAR_CONST")]
        Const = 0x2,
        [NativeName("Name", "VAR_DISPATCH")]
        Dispatch = 0x3,
    }
}
