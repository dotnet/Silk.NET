// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN"]/*' />
public unsafe partial struct HIDP_UNKNOWN_TOKEN
{
    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.Token"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Token;

    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.Reserved"]/*' />
    [NativeTypeName("UCHAR[3]")]
    public fixed byte Reserved[3];

    /// <include file='HIDP_UNKNOWN_TOKEN.xml' path='doc/member[@name="HIDP_UNKNOWN_TOKEN.BitField"]/*' />
    [NativeTypeName("ULONG")]
    public uint BitField;
}
