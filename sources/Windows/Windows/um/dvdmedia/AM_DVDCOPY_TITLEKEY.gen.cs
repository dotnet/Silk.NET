// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY"]/*' />
public unsafe partial struct AM_DVDCOPY_TITLEKEY
{
    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.KeyFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint KeyFlags;

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.Reserved1"]/*' />
    [NativeTypeName("ULONG[2]")]
    public fixed uint Reserved1[2];

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.TitleKey"]/*' />
    [NativeTypeName("UCHAR[6]")]
    public fixed byte TitleKey[6];

    /// <include file='AM_DVDCOPY_TITLEKEY.xml' path='doc/member[@name="AM_DVDCOPY_TITLEKEY.Reserved2"]/*' />
    [NativeTypeName("UCHAR[2]")]
    public fixed byte Reserved2[2];
}
