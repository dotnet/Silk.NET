// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW"]/*' />
public unsafe partial struct HELPWININFOW
{
    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.wStructSize"]/*' />
    public int wStructSize;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.x"]/*' />
    public int x;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.y"]/*' />
    public int y;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.dx"]/*' />
    public int dx;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.dy"]/*' />
    public int dy;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.wMax"]/*' />
    public int wMax;

    /// <include file='HELPWININFOW.xml' path='doc/member[@name="HELPWININFOW.rgchMember"]/*' />
    [NativeTypeName("WCHAR[2]")]
    public fixed ushort rgchMember[2];
}
