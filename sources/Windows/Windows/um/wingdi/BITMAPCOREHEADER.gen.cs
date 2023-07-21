// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER"]/*' />
public partial struct BITMAPCOREHEADER
{
    /// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER.bcSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint bcSize;

    /// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER.bcWidth"]/*' />
    [NativeTypeName("WORD")]
    public ushort bcWidth;

    /// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER.bcHeight"]/*' />
    [NativeTypeName("WORD")]
    public ushort bcHeight;

    /// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER.bcPlanes"]/*' />
    [NativeTypeName("WORD")]
    public ushort bcPlanes;

    /// <include file='BITMAPCOREHEADER.xml' path='doc/member[@name="BITMAPCOREHEADER.bcBitCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort bcBitCount;
}
