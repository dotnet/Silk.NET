// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO"]/*' />
public partial struct WINDOWINFO
{
    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.rcWindow"]/*' />
    public RECT rcWindow;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.rcClient"]/*' />
    public RECT rcClient;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.dwExStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwExStyle;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.dwWindowStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwWindowStatus;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.cxWindowBorders"]/*' />
    public uint cxWindowBorders;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.cyWindowBorders"]/*' />
    public uint cyWindowBorders;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.atomWindowType"]/*' />
    [NativeTypeName("ATOM")]
    public ushort atomWindowType;

    /// <include file='WINDOWINFO.xml' path='doc/member[@name="WINDOWINFO.wCreatorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort wCreatorVersion;
}
