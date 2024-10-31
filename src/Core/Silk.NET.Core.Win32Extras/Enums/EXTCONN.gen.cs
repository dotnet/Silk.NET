// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagEXTCONN")]
    public enum EXTCONN : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Strong\"")]
        [NativeName("Name", "EXTCONN_STRONG")]
        ExtconnStrong = 0x1,
        [Obsolete("Deprecated in favour of \"Weak\"")]
        [NativeName("Name", "EXTCONN_WEAK")]
        ExtconnWeak = 0x2,
        [Obsolete("Deprecated in favour of \"Callable\"")]
        [NativeName("Name", "EXTCONN_CALLABLE")]
        ExtconnCallable = 0x4,
        [NativeName("Name", "EXTCONN_STRONG")]
        Strong = 0x1,
        [NativeName("Name", "EXTCONN_WEAK")]
        Weak = 0x2,
        [NativeName("Name", "EXTCONN_CALLABLE")]
        Callable = 0x4,
    }
}
