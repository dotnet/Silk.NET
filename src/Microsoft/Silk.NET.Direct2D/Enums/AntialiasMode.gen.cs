// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_ANTIALIAS_MODE")]
    public enum AntialiasMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PerPrimitive\"")]
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_PER_PRIMITIVE")]
        AntialiasModePerPrimitive = 0x0,
        [Obsolete("Deprecated in favour of \"Aliased\"")]
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_ALIASED")]
        AntialiasModeAliased = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_FORCE_DWORD")]
        AntialiasModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_PER_PRIMITIVE")]
        PerPrimitive = 0x0,
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_ALIASED")]
        Aliased = 0x1,
        [NativeName("Name", "D2D1_ANTIALIAS_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
