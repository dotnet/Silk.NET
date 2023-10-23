// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Native
{
    public enum NativeStringEncoding
    {
        BStr = UnmanagedType.BStr,
        LPStr = UnmanagedType.LPStr,
        LPTStr = UnmanagedType.LPTStr,
        LPUTF8Str = UnmanagedType.LPUTF8Str,
        LPWStr = UnmanagedType.LPWStr,
        WinString = UnmanagedType.WinString,
        Ansi = LPStr,
        Auto = LPTStr,
        Uni = LPWStr,
        UTF8 = LPUTF8Str,
    }
}
