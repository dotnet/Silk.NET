// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT"]/*' />
public partial struct DRAWITEMSTRUCT
{
    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.CtlType"]/*' />
    public uint CtlType;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.CtlID"]/*' />
    public uint CtlID;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.itemID"]/*' />
    public uint itemID;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.itemAction"]/*' />
    public uint itemAction;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.itemState"]/*' />
    public uint itemState;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.hwndItem"]/*' />
    public HWND hwndItem;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.hDC"]/*' />
    public HDC hDC;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.rcItem"]/*' />
    public RECT rcItem;

    /// <include file='DRAWITEMSTRUCT.xml' path='doc/member[@name="DRAWITEMSTRUCT.itemData"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint itemData;
}
