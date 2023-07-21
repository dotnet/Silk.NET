// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DRAWPATRECT.xml' path='doc/member[@name="DRAWPATRECT"]/*' />
public partial struct DRAWPATRECT
{
    /// <include file='DRAWPATRECT.xml' path='doc/member[@name="DRAWPATRECT.ptPosition"]/*' />
    public POINT ptPosition;

    /// <include file='DRAWPATRECT.xml' path='doc/member[@name="DRAWPATRECT.ptSize"]/*' />
    public POINT ptSize;

    /// <include file='DRAWPATRECT.xml' path='doc/member[@name="DRAWPATRECT.wStyle"]/*' />
    [NativeTypeName("WORD")]
    public ushort wStyle;

    /// <include file='DRAWPATRECT.xml' path='doc/member[@name="DRAWPATRECT.wPattern"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPattern;
}
