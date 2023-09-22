// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapLockFlags")]
    public enum WICBitmapLockFlags : int
    {
        [Obsolete("Deprecated in favour of \"BitmapLockRead\"")]
        [NativeName("Name", "WICBitmapLockRead")]
        WicbitmapLockRead = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapLockWrite\"")]
        [NativeName("Name", "WICBitmapLockWrite")]
        WicbitmapLockWrite = 0x2,
        [Obsolete("Deprecated in favour of \"ItmaplockflagsForceDword\"")]
        [NativeName("Name", "WICBITMAPLOCKFLAGS_FORCE_DWORD")]
        WicbitmaplockflagsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICBitmapLockRead")]
        BitmapLockRead = 0x1,
        [NativeName("Name", "WICBitmapLockWrite")]
        BitmapLockWrite = 0x2,
        [NativeName("Name", "WICBITMAPLOCKFLAGS_FORCE_DWORD")]
        ItmaplockflagsForceDword = 0x7FFFFFFF,
    }
}
