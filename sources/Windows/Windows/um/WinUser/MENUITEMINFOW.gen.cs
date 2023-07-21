// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW"]/*' />
public unsafe partial struct MENUITEMINFOW
{
    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.fMask"]/*' />
    public uint fMask;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.fType"]/*' />
    public uint fType;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.fState"]/*' />
    public uint fState;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.wID"]/*' />
    public uint wID;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.hSubMenu"]/*' />
    public HMENU hSubMenu;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.hbmpChecked"]/*' />
    public HBITMAP hbmpChecked;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.hbmpUnchecked"]/*' />
    public HBITMAP hbmpUnchecked;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.dwItemData"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint dwItemData;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.dwTypeData"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* dwTypeData;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.cch"]/*' />
    public uint cch;

    /// <include file='MENUITEMINFOW.xml' path='doc/member[@name="MENUITEMINFOW.hbmpItem"]/*' />
    public HBITMAP hbmpItem;
}
