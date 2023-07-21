// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR"]/*' />
public unsafe partial struct DVD_ATR
{
    /// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR.ulCAT"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCAT;

    /// <include file='DVD_ATR.xml' path='doc/member[@name="DVD_ATR.pbATRI"]/*' />
    [NativeTypeName("BYTE[768]")]
    public fixed byte pbATRI[768];
}
