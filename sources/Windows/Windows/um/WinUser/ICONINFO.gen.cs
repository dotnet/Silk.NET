// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO"]/*' />
public partial struct ICONINFO
{
    /// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO.fIcon"]/*' />
    public BOOL fIcon;

    /// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO.xHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint xHotspot;

    /// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO.yHotspot"]/*' />
    [NativeTypeName("DWORD")]
    public uint yHotspot;

    /// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO.hbmMask"]/*' />
    public HBITMAP hbmMask;

    /// <include file='ICONINFO.xml' path='doc/member[@name="ICONINFO.hbmColor"]/*' />
    public HBITMAP hbmColor;
}
