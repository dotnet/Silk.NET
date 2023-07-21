// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PALETTEENTRY.xml' path='doc/member[@name="PALETTEENTRY"]/*' />
public partial struct PALETTEENTRY
{
    /// <include file='PALETTEENTRY.xml' path='doc/member[@name="PALETTEENTRY.peRed"]/*' />
    public byte peRed;

    /// <include file='PALETTEENTRY.xml' path='doc/member[@name="PALETTEENTRY.peGreen"]/*' />
    public byte peGreen;

    /// <include file='PALETTEENTRY.xml' path='doc/member[@name="PALETTEENTRY.peBlue"]/*' />
    public byte peBlue;

    /// <include file='PALETTEENTRY.xml' path='doc/member[@name="PALETTEENTRY.peFlags"]/*' />
    public byte peFlags;
}
