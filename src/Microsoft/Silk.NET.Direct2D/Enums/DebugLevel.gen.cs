// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_DEBUG_LEVEL")]
    public enum DebugLevel : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_DEBUG_LEVEL_NONE")]
        DebugLevelNone = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "D2D1_DEBUG_LEVEL_ERROR")]
        DebugLevelError = 0x1,
        [Obsolete("Deprecated in favour of \"Warning\"")]
        [NativeName("Name", "D2D1_DEBUG_LEVEL_WARNING")]
        DebugLevelWarning = 0x2,
        [Obsolete("Deprecated in favour of \"Information\"")]
        [NativeName("Name", "D2D1_DEBUG_LEVEL_INFORMATION")]
        DebugLevelInformation = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DEBUG_LEVEL_FORCE_DWORD")]
        DebugLevelForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DEBUG_LEVEL_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_DEBUG_LEVEL_ERROR")]
        Error = 0x1,
        [NativeName("Name", "D2D1_DEBUG_LEVEL_WARNING")]
        Warning = 0x2,
        [NativeName("Name", "D2D1_DEBUG_LEVEL_INFORMATION")]
        Information = 0x3,
        [NativeName("Name", "D2D1_DEBUG_LEVEL_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
