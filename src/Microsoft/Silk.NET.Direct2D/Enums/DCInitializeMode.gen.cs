// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_DC_INITIALIZE_MODE")]
    public enum DCInitializeMode : int
    {
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_COPY")]
        DCInitializeModeCopy = 0x0,
        [Obsolete("Deprecated in favour of \"Clear\"")]
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_CLEAR")]
        DCInitializeModeClear = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_FORCE_DWORD")]
        DCInitializeModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_COPY")]
        Copy = 0x0,
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_CLEAR")]
        Clear = 0x1,
        [NativeName("Name", "D2D1_DC_INITIALIZE_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
