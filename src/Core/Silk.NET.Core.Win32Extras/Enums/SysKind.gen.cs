// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSYSKIND")]
    public enum SysKind : int
    {
        [Obsolete("Deprecated in favour of \"Win16\"")]
        [NativeName("Name", "SYS_WIN16")]
        SysWin16 = 0x0,
        [Obsolete("Deprecated in favour of \"Win32\"")]
        [NativeName("Name", "SYS_WIN32")]
        SysWin32 = 0x1,
        [Obsolete("Deprecated in favour of \"Mac\"")]
        [NativeName("Name", "SYS_MAC")]
        SysMac = 0x2,
        [Obsolete("Deprecated in favour of \"Win64\"")]
        [NativeName("Name", "SYS_WIN64")]
        SysWin64 = 0x3,
        [NativeName("Name", "SYS_WIN16")]
        Win16 = 0x0,
        [NativeName("Name", "SYS_WIN32")]
        Win32 = 0x1,
        [NativeName("Name", "SYS_MAC")]
        Mac = 0x2,
        [NativeName("Name", "SYS_WIN64")]
        Win64 = 0x3,
    }
}
