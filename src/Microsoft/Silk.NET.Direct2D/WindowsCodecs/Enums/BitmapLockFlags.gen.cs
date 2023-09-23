// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapLockFlags")]
    public enum BitmapLockFlags : int
    {
        [NativeName("Name", "WICBitmapLockRead")]
        BitmapLockRead = 0x1,
        [NativeName("Name", "WICBitmapLockWrite")]
        BitmapLockWrite = 0x2,
        [NativeName("Name", "WICBITMAPLOCKFLAGS_FORCE_DWORD")]
        ItmaplockflagsForceDword = 0x7FFFFFFF,
    }
}
