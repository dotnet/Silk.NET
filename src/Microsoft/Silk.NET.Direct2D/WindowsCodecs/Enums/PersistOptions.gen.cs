// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICPersistOptions")]
    public enum PersistOptions : int
    {
        [NativeName("Name", "WICPersistOptionDefault")]
        Default = 0x0,
        [NativeName("Name", "WICPersistOptionLittleEndian")]
        LittleEndian = 0x0,
        [NativeName("Name", "WICPersistOptionBigEndian")]
        BigEndian = 0x1,
        [NativeName("Name", "WICPersistOptionStrictFormat")]
        StrictFormat = 0x2,
        [NativeName("Name", "WICPersistOptionNoCacheStream")]
        NoCacheStream = 0x4,
        [NativeName("Name", "WICPersistOptionPreferUTF8")]
        PreferUtf8 = 0x8,
        [NativeName("Name", "WICPersistOptionMask")]
        Mask = 0xFFFF,
    }
}
