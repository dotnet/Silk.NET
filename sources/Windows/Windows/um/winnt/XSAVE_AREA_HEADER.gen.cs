// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='XSAVE_AREA_HEADER.xml' path='doc/member[@name="XSAVE_AREA_HEADER"]/*' />
public unsafe partial struct XSAVE_AREA_HEADER
{
    /// <include file='XSAVE_AREA_HEADER.xml' path='doc/member[@name="XSAVE_AREA_HEADER.Mask"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Mask;

    /// <include file='XSAVE_AREA_HEADER.xml' path='doc/member[@name="XSAVE_AREA_HEADER.CompactionMask"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong CompactionMask;

    /// <include file='XSAVE_AREA_HEADER.xml' path='doc/member[@name="XSAVE_AREA_HEADER.Reserved2"]/*' />
    [NativeTypeName("DWORD64[6]")]
    public fixed ulong Reserved2[6];
}
