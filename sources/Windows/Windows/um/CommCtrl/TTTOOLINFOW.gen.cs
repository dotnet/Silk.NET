// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW"]/*' />
public unsafe partial struct TTTOOLINFOW
{
    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.uFlags"]/*' />
    public uint uFlags;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.uId"]/*' />
    [NativeTypeName("UINT_PTR")]
    public nuint uId;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.rect"]/*' />
    public RECT rect;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.hinst"]/*' />
    public HINSTANCE hinst;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.lpszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszText;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='TTTOOLINFOW.xml' path='doc/member[@name="TTTOOLINFOW.lpReserved"]/*' />
    public void* lpReserved;
}
