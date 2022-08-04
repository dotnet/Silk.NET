// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "DCOMPOSITION_BORDER_MODE")]
    public enum BorderMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Soft\"")]
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_SOFT")]
        BorderModeSoft = 0x0,
        [Obsolete("Deprecated in favour of \"Hard\"")]
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_HARD")]
        BorderModeHard = 0x1,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_INHERIT")]
        BorderModeInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_SOFT")]
        Soft = 0x0,
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_HARD")]
        Hard = 0x1,
        [NativeName("Name", "DCOMPOSITION_BORDER_MODE_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
