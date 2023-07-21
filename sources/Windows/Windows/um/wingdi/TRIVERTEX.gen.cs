// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX"]/*' />
public partial struct TRIVERTEX
{
    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.x"]/*' />
    [NativeTypeName("LONG")]
    public int x;

    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.y"]/*' />
    [NativeTypeName("LONG")]
    public int y;

    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Red"]/*' />
    [NativeTypeName("COLOR16")]
    public ushort Red;

    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Green"]/*' />
    [NativeTypeName("COLOR16")]
    public ushort Green;

    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Blue"]/*' />
    [NativeTypeName("COLOR16")]
    public ushort Blue;

    /// <include file='TRIVERTEX.xml' path='doc/member[@name="TRIVERTEX.Alpha"]/*' />
    [NativeTypeName("COLOR16")]
    public ushort Alpha;
}
