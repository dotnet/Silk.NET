// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION"]/*' />
public unsafe partial struct DIBSECTION
{
    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBm"]/*' />
    public BITMAP dsBm;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBmih"]/*' />
    public BITMAPINFOHEADER dsBmih;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsBitfields"]/*' />
    [NativeTypeName("DWORD[3]")]
    public fixed uint dsBitfields[3];

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dshSection"]/*' />
    public HANDLE dshSection;

    /// <include file='DIBSECTION.xml' path='doc/member[@name="DIBSECTION.dsOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dsOffset;
}
