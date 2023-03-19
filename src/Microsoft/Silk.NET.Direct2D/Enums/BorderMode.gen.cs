// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BORDER_MODE")]
    public enum BorderMode : int
    {
        [Obsolete("Deprecated in favour of \"Soft\"")]
        [NativeName("Name", "D2D1_BORDER_MODE_SOFT")]
        BorderModeSoft = 0x0,
        [Obsolete("Deprecated in favour of \"Hard\"")]
        [NativeName("Name", "D2D1_BORDER_MODE_HARD")]
        BorderModeHard = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BORDER_MODE_FORCE_DWORD")]
        BorderModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BORDER_MODE_SOFT")]
        Soft = 0x0,
        [NativeName("Name", "D2D1_BORDER_MODE_HARD")]
        Hard = 0x1,
        [NativeName("Name", "D2D1_BORDER_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
